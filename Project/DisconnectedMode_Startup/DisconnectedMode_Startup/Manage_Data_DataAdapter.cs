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
    public partial class Manage_Data_DataAdapter : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        //To Make Default Value of RadioButton checked -> 
        //Form Design, Select RadioButton,RightClick,Properties, Checked = True

        public Manage_Data_DataAdapter()
        {
            InitializeComponent();
        }

       
        private void loadInformation_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "";
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            
        }

       

   
        }
    }

