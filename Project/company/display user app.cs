using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


namespace company
{
    public partial class display_user_app : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        private string userssn;

        public display_user_app(string userSSN)
        {
            this.userssn = userSSN;
            InitializeComponent();
        }

        private void display_user_app_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "COUNTUSERAPPLICATION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("resultoutput", Convert.ToInt32(userssn));
            cmd.Parameters.Add("numofapp", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();
            textBox1.Text = cmd.Parameters["numofapp"].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
