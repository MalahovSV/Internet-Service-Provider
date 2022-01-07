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
        string _ID;
        public AddContractWindow(bool POST, string ID)
        {
            InitializeComponent();

            loadData();

            if (POST == true)
            {
                addRecord.Visible = true;
            } else
            {
                upRecord.Visible = true;
                _ID = ID;
                loadRecord(_ID);
            }

            
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

        public void loadRecord(string ID)
        {
            DataTable record = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable($@"select number_contract, date_contract, adress, id_subscriber, id_tariff from contracts, subscriber, tariff
where contracts.fk_subscriber = id_subscriber and fk_tariff = id_tariff and id_contracts = {ID}");
            numberContract.Text = record.Rows[0].ItemArray[0].ToString();
            dateContract.Value = DateTime.Parse(record.Rows[0].ItemArray[1].ToString());
            adressContract.Text = record.Rows[0].ItemArray[2].ToString();
            clientCombo.SelectedValue = record.Rows[0].ItemArray[3].ToString();
            tariffCombo.SelectedValue = record.Rows[0].ItemArray[4].ToString();


        }

        public void eventsClickButton()
        {
            addRecord.Click += (s, e) =>
            {
                string dateSql = $@"{dateContract.Value.Year}-{dateContract.Value.Month}-{dateContract.Value.Day}";
                string command = $@"insert into contracts values (NULL, '{dateSql}', '{numberContract.Text}', '{adressContract.Text}', {tariffCombo.SelectedValue}, {clientCombo.SelectedValue})";
                DBMySqlUtils.ExecuteCommand(command);
                MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK);
            };
            upRecord.Click += (s, e) =>
            {
                string dateSql = $@"{dateContract.Value.Year}-{dateContract.Value.Month}-{dateContract.Value.Day}";
                string command = $@"update contracts set date_contract = '{dateSql}',
                number_contract = '{numberContract.Text}',
                adress = '{adressContract.Text}',
                fk_tariff = {tariffCombo.SelectedValue},
                fk_subscriber = {clientCombo.SelectedValue} 
                where id_contracts = {_ID}"; 
                DBMySqlUtils.ExecuteCommand(command);
                MessageBox.Show("Запись изменена", "Сообщение", MessageBoxButtons.OK);
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
