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
            //eventsButton();
        }


        private void eventsButton()
        {
            SyncCommandButton.Click += (s, e) =>
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                using (MySqlConnection connection = new MySqlConnection(DBMySqlUtils.GetStringConnection()))
                {
                    connection.Open();
                    #region InsertCommandSubscribers
                    myAdapter.InsertCommand = new MySqlCommand("insert into subscriber values (NULL, @surname, @first_name, @second_name, @number_phone)", connection);
                    myAdapter.InsertCommand.Parameters.Add("@surname", MySqlDbType.VarChar, 30, "Фамилия");
                    myAdapter.InsertCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 30, "Имя");
                    myAdapter.InsertCommand.Parameters.Add("@second_name", MySqlDbType.VarChar, 30, "Отчество");
                    myAdapter.InsertCommand.Parameters.Add("@number_phone", MySqlDbType.VarChar, 17, "Номер телефона");
                    #endregion

                    #region DeleteCommandSubscriber
                    myAdapter.DeleteCommand = new MySqlCommand("delete from subscriber where id_subscriber = @id_subscriber", connection);
                    myAdapter.DeleteCommand.Parameters.Add("@id_subscriber", MySqlDbType.VarChar, 5, "ID");
                    #endregion

                    #region UpdateCommandSubscriber

                    myAdapter.UpdateCommand = new MySqlCommand(@"	update subscriber set 	surname = @surname,
                                                                                            first_name = @first_name,
                                                                                            second_name = @second_name,
                                                                                            number_phone = @number_phone
                                                                    where id_subscriber = @id_subscriber", connection);

                    myAdapter.UpdateCommand.Parameters.Add("@id_subscriber", MySqlDbType.VarChar, 5, "ID");
                    myAdapter.UpdateCommand.Parameters.Add("@surname", MySqlDbType.VarChar, 30, "Фамилия");
                    myAdapter.UpdateCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 30, "Имя");
                    myAdapter.UpdateCommand.Parameters.Add("@second_name", MySqlDbType.VarChar, 30, "Отчество");
                    myAdapter.UpdateCommand.Parameters.Add("@number_phone", MySqlDbType.VarChar, 17, "Номер телефона");

                    #endregion

                    myAdapter.Update(ContractsTable);
                    MessageBox.Show("Операции проведены успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }


            };
        }

        private void loadData()
        {
            DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable(@"select id_contracts as 'ID',
                                                                        number_contract as 'Номер договора',
                                                                        date_contract as 'Дата составления договора',
                                                                        adress as 'Адрес абонента',
                                                                        name_tariff as 'Тариф',
                                                                        concat(surname, ' ', first_name, ' ', second_name) as 'Клиент'
                                                                from contracts, subscriber, tariff
                                                                where tariff.id_tariff = contracts.fk_tariff and
                                                                        subscriber.id_subscriber = contracts.fk_subscriber");
            ContractsTable = dt;
            tableContracts.DataSource = ContractsTable;

            tableContracts.Columns[0].ReadOnly = true;

            tableContracts.CellClick += new DataGridViewCellEventHandler(CreateOnComboBoxInTableContracts);

            installColorBackgroundButton();
        }


        private void CreateOnComboBoxInTableContracts(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            DataTable tariffs = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable("select name_tariff from tariff");
            int i = 0;
            while (tariffs.Rows.Count > i)
            {
                comboBoxCell.Items.Add(tariffs.Rows[i].ItemArray[0].ToString());
                i++;
            }
            tableContracts.Rows[tableContracts.CurrentRow.Index].Cells[4] = comboBoxCell;
        }




        private void installColorBackgroundButton()
        {
            var temp = ConfigurationManager.AppSettings["BackgroundButtonMenu"].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Color color = Color.FromArgb(Int32.Parse(temp[0]), Int32.Parse(temp[1]), Int32.Parse(temp[2]));
            SyncCommandButton.BackColor = color;
        }
    }
}
