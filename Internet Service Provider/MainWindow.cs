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

namespace Internet_Service_Provider
{
    public partial class MainWindow : Form
    {
        private List<UserControl> _controlls;
        private AuthorizationWindow _authorizationWindow;
        public MainWindow(AuthorizationWindow authorizationWindow)
        {
            InitializeComponent();
            _authorizationWindow = authorizationWindow;
            _authorizationWindow.Hide();
            eventsWindow();
            dropColorButtonMenu();
            eventsClickMenuButton();
        }


        private void eventsWindow()
        {
            this.FormClosed += (s, e) => { _authorizationWindow.Show(); };
        }


        private void eventsClickMenuButton()
        {



            contractControl.Click += (s, e) =>
            {
                installColorForMenuButton(contractControl);
                installControl(_controlls[0]);
                statusButton.Text = "Договоры";
                
            };
            subscriberButton.Click += (s, e) => 
            { 
                installColorForMenuButton(subscriberButton);
                installControl(_controlls[1]);
                statusButton.Text = "Клиенты";
                
            };
            tariffsButton.Click += (s, e) => 
            { 
                installColorForMenuButton(tariffsButton); 
                installControl(_controlls[2]);
                statusButton.Text = "Тарифы";
            };
            button4.Click += (s, e) => { installColorForMenuButton(button4); };
            button5.Click += (s, e) => { installColorForMenuButton(button5); };

        }

        private void installControl(UserControl installingUserControl)
        {
            if (workSpace.Controls.Count > 0)
                workSpace.Controls.RemoveAt(0);
            UserControl contracts = installingUserControl;
            workSpace.Controls.Add(contracts);
            contracts.Dock = DockStyle.Fill;
        }

        private void installColorForMenuButton(Button clickedButton)
        {
            dropColorButtonMenu();
            clickedButton.BackColor = Color.BlueViolet;

        }

        private void dropColorButtonMenu()
        {
            var temp = ConfigurationManager.AppSettings["BackgroundButtonMenu"].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Color color = Color.FromArgb(Int32.Parse(temp[0]), Int32.Parse(temp[1]), Int32.Parse(temp[2]));
            contractControl.BackColor = color;
            subscriberButton.BackColor = color;
            tariffsButton.BackColor = color;
            button4.BackColor = color;
            button5.BackColor = color;
        }

        private void contractControl_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _controlls = new List<UserControl>();
            _controlls.Add(new Controls.Contract.ContractControl());
            _controlls.Add(new Controls.Subscriber.SubscriberControl());
            _controlls.Add(new Controls.Tariffs.TariffsControl());
        }

        private void tariffsButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
