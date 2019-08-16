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
    public partial class viewcv : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public viewcv()
        {
            InitializeComponent();
        }

        private void viewcv_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            /*OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ssn from applicants";
            cmd.CommandType = CommandType.Text;
            OracleDataReader xs = cmd.ExecuteReader();
            while (xs.Read())
            {
                comboBox1.Items.Add(xs[0]);
            }
            xs.Close();
            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter dr = new OracleDataAdapter("select * from applicants", ordb);
            dr.SelectCommand.Parameters.Add("n", textBox1.Text);
            dr.Fill(ds, "fssn");
            OracleDataAdapter dr2 = new OracleDataAdapter("select * from cvpreviousjob", ordb);
            dr2.SelectCommand.Parameters.Add("n", textBox1.Text);
            dr2.Fill(ds, "fcv");
            DataRelation da = new DataRelation("fk", ds.Tables[0].Columns["ssn"], ds.Tables[1].Columns["ssn"]);
            ds.Relations.Add(da);
            BindingSource bs_master = new BindingSource(ds, "fssn");
            BindingSource child = new BindingSource(bs_master, "fk");
            dataGridView1.DataSource = bs_master;
            dataGridView2.DataSource = child;

            //text box view 


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select degreeofeducation from cv where ssn=:d";
            cmd.Parameters.Add("d", textBox1.Text);
            OracleDataReader sa = cmd.ExecuteReader();
            if (sa.Read())
            {
                richTextBox1.Text = sa[0].ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string accept = "accept";
string yes = "yes";*/
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "update appllication set status='accepted' where ssn=:a";
            cmd2.Parameters.Add("a", textBox1.Text);
            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("accepted" + "               " + textBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "update appllication set status='rejected' where ssn=:a";
            cmd2.Parameters.Add("a", textBox1.Text);
            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("rejected" + "               " + textBox1.Text);
            }

        }
    }
}
