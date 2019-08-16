using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DisconnectedMode_Startup
{
    public partial class MasterDetail : Form
    {
        public MasterDetail()
        {
            InitializeComponent();
        }

        private void MasterDetail_Load(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            
        }
    }
}
