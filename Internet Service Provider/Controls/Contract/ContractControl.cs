using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider.Controls.Contract
{
    public partial class ContractControl : UserControl
    {
        DataTable ContractsTable;
        public ContractControl()
        {
            InitializeComponent();
            loadData();
            eventsButton();
        }


        private void eventsButton()
        {
            SyncCommandButton.Click += (s, e) =>
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                using (MySqlConnection connection = new MySqlConnection(DBMySqlUtils.GetStringConnection()))
                {
                    connection.Open();

                    #region DeleteCommandSubscriber
                    myAdapter.DeleteCommand = new MySqlCommand("delete from contracts where id_contracts = @id_contracts", connection);
                    myAdapter.DeleteCommand.Parameters.Add("@id_contracts", MySqlDbType.VarChar, 5, "ID");
                    #endregion

                    myAdapter.Update(ContractsTable);
                    MessageBox.Show("Операции проведены успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }


            };
            ShowWindowCreater.Click += (s, e) =>
            {
                showAddContractWindow(true, null);

            };

            updateRecordButton.Click += (s, e) =>
            {
                showAddContractWindow(false, tableContracts.SelectedRows[0].Cells[0].Value.ToString());
            };
        }

        private static void showAddContractWindow(bool Post, string id)
        {
            AddContractWindow addContract = new AddContractWindow(Post, id);
            addContract.ShowDialog();
        }

        private void loadData()
        {
            DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable(@"select id_contracts as 'ID',
                                                                        number_contract as 'Номер договора',
                                                                        date_contract as 'Дата составления договора',
                                                                        adress as 'Адрес абонента',
                                                                        name_tariff as 'Тариф',
                                                                        concat(surname, ' ', first_name, ' ', second_name) as 'Клиент',
                                                                        fk_tariff, fk_subscriber
                                                                from contracts, subscriber, tariff
                                                                where tariff.id_tariff = contracts.fk_tariff and
                                                                        subscriber.id_subscriber = contracts.fk_subscriber");

            ContractsTable = dt;
            tableContracts.DataSource = ContractsTable;
            
            
            
            
            tableContracts.Columns[0].ReadOnly = true;
            tableContracts.Columns[6].Visible = false;
            tableContracts.Columns[7].Visible = false;
            
            
            installColorBackgroundButton();
        }






        private void installColorBackgroundButton()
        {
            var temp = ConfigurationManager.AppSettings["BackgroundButtonMenu"].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Color color = Color.FromArgb(Int32.Parse(temp[0]), Int32.Parse(temp[1]), Int32.Parse(temp[2]));
            SyncCommandButton.BackColor = color;
        }

        private void tableContracts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.ThrowException = false;
        }

        private void tableContracts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (tableContracts.CurrentCell.ColumnIndex == 4 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                //comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            ComboBox cellComboBox = (ComboBox)tableContracts.EditingControl;
            
            if(cellComboBox.SelectedValue !=null || cellComboBox.SelectedValue.ToString() != "")
                MessageBox.Show(cellComboBox.SelectedValue.ToString());

        }

        private void PrintReport_Click(object sender, EventArgs e)
        {
            Classes.PrintReportWord excelReport = new Classes.PrintReportWord();
            if (tableContracts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выделено строк", "Ошибка", MessageBoxButtons.OK);
            } else
            {
                //tableContracts.SelectedRows[0].Cells[0].Value;


                string sqlCommand = $@"select number_contract, CONCAT(surname, ' ', first_name, ' ', second_name) as FIO,
        date_birth, adress_subscriber, adress, number_phone, name_tariff, price, date_contract, serial_passport, number_passport,
        who_passport, date_passport
        from subscriber, contracts, tariff
        where subscriber.id_subscriber = contracts.fk_subscriber and
        tariff.id_tariff = contracts.fk_tariff and id_contracts = {tableContracts.SelectedRows[0].Cells[0].Value}";
                DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable(sqlCommand);

                
                excelReport.PrintReport(dt);
            }
            
        }

        private void refreshTable_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void ContractControl_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBMySqlUtils.ExecuteCommand($"delete from contracts where id_contracts = {tableContracts.Rows[0].Cells[0].Value.ToString()}");
            loadData();
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAddContractWindow(false, tableContracts.SelectedRows[0].Cells[0].Value.ToString());
            loadData();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAddContractWindow(true, null);
            loadData();
        }
    }
}
