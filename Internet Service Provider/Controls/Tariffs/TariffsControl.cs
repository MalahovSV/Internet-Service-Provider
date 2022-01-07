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

namespace Internet_Service_Provider.Controls.Tariffs
{
    public partial class TariffsControl : UserControl
    {
        DataTable TariffsTable;
        public TariffsControl()
        {
            InitializeComponent();
            loadData();
            eventsButton();
            tableTariffs.DataError += (s, e) =>
            {
                tableTariffs.EditingControl.BackColor = Color.Red;
                MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }


        private void eventsButton()
        {
            SyncCommandButton.Click += (s, e) =>
            {
                try
                {
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                    using (MySqlConnection connection = new MySqlConnection(DBMySqlUtils.GetStringConnection()))
                    {
                        connection.Open();
                        #region InsertCommandSubscribers
                        myAdapter.InsertCommand = new MySqlCommand("insert into tariff values (NULL, @name_tariff, @price, @speed, @about)", connection);
                        myAdapter.InsertCommand.Parameters.Add("@name_tariff", MySqlDbType.VarChar, 30, "Наименование тарифа");
                        myAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.VarChar, 30, "Цена");
                        myAdapter.InsertCommand.Parameters.Add("@speed", MySqlDbType.VarChar, 30, "Скорость (Мбит/с)");
                        myAdapter.InsertCommand.Parameters.Add("@about", MySqlDbType.VarChar, 10000, "Подробно");
                        #endregion

                        #region DeleteCommandSubscriber
                        myAdapter.DeleteCommand = new MySqlCommand("delete from tariff where id_tariff = @id_tariff", connection);
                        myAdapter.DeleteCommand.Parameters.Add("@id_tariff", MySqlDbType.VarChar, 5, "ID");
                        #endregion

                        #region UpdateCommandSubscriber

                        myAdapter.UpdateCommand = new MySqlCommand(@"	update tariff set 	name_tariff = @name_tariff,
                                                                                            price = @price,
                                                                                            speed = @speed,
                                                                                            about = @about
                                                                    where id_tariff = @id_tariff", connection);

                        myAdapter.UpdateCommand.Parameters.Add("@id_tariff", MySqlDbType.VarChar, 5, "ID");
                        myAdapter.UpdateCommand.Parameters.Add("@name_tariff", MySqlDbType.VarChar, 30, "Наименование тарифа");
                        myAdapter.UpdateCommand.Parameters.Add("@price", MySqlDbType.VarChar, 30, "Цена");
                        myAdapter.UpdateCommand.Parameters.Add("@speed", MySqlDbType.VarChar, 30, "Скорость (Мбит/с)");
                        myAdapter.UpdateCommand.Parameters.Add("@about", MySqlDbType.VarChar, 10000, "Подробно");

                        #endregion

                        myAdapter.Update(TariffsTable);
                        MessageBox.Show("Операции проведены успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            refreshTable.Click += (s, e) =>
            {
                loadData();
            };
        }

        private void loadData()
        {
            DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable(@"SELECT id_tariff as 'ID',
                                                                                   name_tariff as 'Наименование тарифа',
                                                                                   price as 'Цена',
                                                                                   speed as 'Скорость (Мбит/с)',
                                                                                   About as 'Подробно'
                                                                            FROM isp.tariff; ");
            TariffsTable = dt;
            tableTariffs.DataSource = TariffsTable;
            tableTariffs.Columns[0].ReadOnly = true;
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
