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
        private List<UserControl> _users;
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
                installControl(_users[0]);
            };
            subscriberButton.Click += (s, e) => 
            { 
                installColorForMenuButton(subscriberButton);
                installControl(_users[1]);
            };
            button3.Click += (s, e) => { installColorForMenuButton(button3); };
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
            button3.BackColor = color;
            button4.BackColor = color;
            button5.BackColor = color;
        }

        private void contractControl_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _users = new List<UserControl>();
            _users.Add(new ContractsControl());
            _users.Add(new SubscriberControl());
        }
    }
}
