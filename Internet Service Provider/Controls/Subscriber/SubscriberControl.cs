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


namespace Internet_Service_Provider.Controls.Subscriber
{
    public partial class SubscriberControl : UserControl
    {
        DataTable SubscriberTable;
        public SubscriberControl()
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
                    #region InsertCommandSubscribers
                    myAdapter.InsertCommand = new MySqlCommand("insert into subscriber values (NULL, @surname, @first_name, @second_name, @number_phone, @who_passport, @date_passport, @number_passport, @serial_passport, @date_birth, @adress_subscriber)", connection);
                    myAdapter.InsertCommand.Parameters.Add("@surname", MySqlDbType.VarChar, 30, "Фамилия");
                    myAdapter.InsertCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 30, "Имя");
                    myAdapter.InsertCommand.Parameters.Add("@second_name", MySqlDbType.VarChar, 30, "Отчество");
                    myAdapter.InsertCommand.Parameters.Add("@number_phone", MySqlDbType.VarChar, 17, "Номер телефона");
                    myAdapter.InsertCommand.Parameters.Add("@date_birth", MySqlDbType.Date, 0, "Дата рождения");
                    myAdapter.InsertCommand.Parameters.Add("@who_passport", MySqlDbType.VarChar, 17, "Кем выдан");
                    myAdapter.InsertCommand.Parameters.Add("@date_passport", MySqlDbType.Date, 0, "Дата выдачи");
                    myAdapter.InsertCommand.Parameters.Add("@serial_passport", MySqlDbType.VarChar, 4, "Серия");
                    myAdapter.InsertCommand.Parameters.Add("@number_passport", MySqlDbType.VarChar, 6, "Номер");
                    myAdapter.InsertCommand.Parameters.Add("@adress_subscriber", MySqlDbType.VarChar, 200, "Место регистрации");
                    #endregion

                    #region DeleteCommandSubscriber
                    myAdapter.DeleteCommand = new MySqlCommand("delete from subscriber where id_subscriber = @id_subscriber", connection);
                    myAdapter.DeleteCommand.Parameters.Add("@id_subscriber", MySqlDbType.VarChar, 5, "ID");
                    #endregion

                    #region UpdateCommandSubscriber

                    myAdapter.UpdateCommand = new MySqlCommand(@"	update subscriber set 	surname = @surname,
first_name = @first_name,
second_name = @second_name,
number_phone = @number_phone,
who_passport = @who_passport,
date_passport=@date_passport,
number_passport=@number_passport,
serial_passport = @serial_passport,
date_birth = @date_birth,
adress_subscriber = @adress_subscriber
where id_subscriber = @id_subscriber", connection);

                    myAdapter.UpdateCommand.Parameters.Add("@id_subscriber", MySqlDbType.VarChar, 5, "ID");
                    myAdapter.UpdateCommand.Parameters.Add("@surname", MySqlDbType.VarChar, 30, "Фамилия");
                    myAdapter.UpdateCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 30, "Имя");
                    myAdapter.UpdateCommand.Parameters.Add("@second_name", MySqlDbType.VarChar, 30, "Отчество");
                    myAdapter.UpdateCommand.Parameters.Add("@number_phone", MySqlDbType.VarChar, 17, "Номер телефона");
                    myAdapter.UpdateCommand.Parameters.Add("@date_birth", MySqlDbType.Date, 0, "Дата рождения");
                    myAdapter.UpdateCommand.Parameters.Add("@who_passport", MySqlDbType.VarChar, 17, "Кем выдан");
                    myAdapter.UpdateCommand.Parameters.Add("@date_passport", MySqlDbType.Date, 0, "Дата выдачи");
                    myAdapter.UpdateCommand.Parameters.Add("@serial_passport", MySqlDbType.VarChar, 4, "Серия");
                    myAdapter.UpdateCommand.Parameters.Add("@number_passport", MySqlDbType.VarChar, 6, "Номер");
                    myAdapter.UpdateCommand.Parameters.Add("@adress_subscriber", MySqlDbType.VarChar, 200, "Место регистрации");
                    #endregion

                    myAdapter.Update(SubscriberTable);
                    MessageBox.Show("Операции проведены успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }


            };
            RefreshTable.Click += (s, e) =>
            {
                loadData();
            };
        }

        private void loadData()
        {
            DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable(@"select id_subscriber as 'ID',
		                                                                           surname as 'Фамилия',
                                                                                   first_name as 'Имя',
                                                                                   second_name as 'Отчество',
                                                                                   number_phone as 'Номер телефона',
                                                                                   date_birth as 'Дата рождения',
                                                                                   who_passport as 'Кем выдан',
                                                                                   date_passport as 'Дата выдачи',
                                                                                   serial_passport as 'Серия',
                                                                                   number_passport as 'Номер',
                                                                                   adress_subscriber as 'Место регистрации'
                                                                            from subscriber");
            SubscriberTable = dt;
            tableSubscriber.DataSource = SubscriberTable;
            installColorBackgroundButton();
        }

        private void installColorBackgroundButton()
        {
            var temp = ConfigurationManager.AppSettings["BackgroundButtonMenu"].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Color color = Color.FromArgb(Int32.Parse(temp[0]), Int32.Parse(temp[1]), Int32.Parse(temp[2]));
            SyncCommandButton.BackColor = color;
        }
    }
}
