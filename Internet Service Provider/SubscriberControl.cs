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
    public partial class SubscriberControl : UserControl
    {
        public SubscriberControl()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            DataTable dt = DBMySqlUtils.ExecuteMySqlCommandAndReturnTable("select * from subscriber");
            tableSubscriber.DataSource = dt;
        }
    }
}
