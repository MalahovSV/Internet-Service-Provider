using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider.Controls.Contract
{
    public partial class AddContractWindow : Form
    {
        public AddContractWindow()
        {
            InitializeComponent();
            loadData();
            eventsClickButton();
        }

        public void loadData()
        {
            DataTable clients = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable("select id_subscriber, concat(surname, ' ', first_name, ' ',  second_name) as 'FIO' from subscriber");
            clientCombo.DataSource = clients;
            clientCombo.DisplayMember = "FIO";
            clientCombo.ValueMember = "id_subscriber";

            DataTable tariffs = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable("select id_tariff, name_tariff from tariff");
            tariffCombo.DataSource = tariffs;
            tariffCombo.DisplayMember = "name_tariff";
            tariffCombo.ValueMember = "id_tariff";

        }

        public void eventsClickButton()
        {
            addRecord.Click += (s, e) =>
            {
                string command = $@"insert into contracts values (NULL, '{dateContract.Value.Date.ToShortDateString()}', '{numberContract.Text}', '{adressContract.Text}', {tariffCombo.SelectedValue}, {clientCombo.SelectedValue})";
                DBMySqlUtils.ExecuteCommand(command);
                MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK);
            };
        }


        private void addRecord_Click(object sender, EventArgs e)
        {

        }

        private void canselOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
