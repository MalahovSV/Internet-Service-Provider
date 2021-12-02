﻿using System;
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
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            eventsButton();
        }

        private void eventsButton()
        {
            LoginButton.Click += (s, e) =>
            {
                if(AuthorizationUtils.CheckDataUser(LoginBox.Text, PasswordBox.Text))
                {
                    MainWindow mainWindow = new MainWindow(this);
                    mainWindow.Show();
                }    
            };
        }

    }
}
