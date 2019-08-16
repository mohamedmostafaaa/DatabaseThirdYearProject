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

namespace company
{
    public partial class remove_job : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        string rodb = "data source =orcl ; user id= scott ; password = tiger; ";
        OracleConnection conn;

        public remove_job()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "deletedadnum";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            cmd2.ExecuteNonQuery();

        }

        private void remove_job_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(rodb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getadnumid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("adnum", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();

        }
    }
}
