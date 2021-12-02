using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider
{
    public partial class ContractsControl : UserControl
    {
        public ContractsControl()
        {
            InitializeComponent();
            loadData();
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
            tableContracts.DataSource = dt;
            tableContracts.Columns[0].ReadOnly = true;

            tableContracts.CellClick += new DataGridViewCellEventHandler(CreateOnComboBoxInTableContracts);

        }

        private void CreateOnComboBoxInTableContracts(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            DataTable tariffs = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable("select name_tariff from tariff");
            int i = 0;
            while(tariffs.Rows.Count > i)
            {
                comboBoxCell.Items.Add(tariffs.Rows[i].ItemArray[0].ToString());
                i++;
            }
            tableContracts.Rows[tableContracts.CurrentRow.Index].Cells[4] = comboBoxCell;
        }
    }
}
