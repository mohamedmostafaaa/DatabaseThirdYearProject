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
    public partial class viewapplicants : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public viewapplicants()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewcv cv = new viewcv();
            cv.Show();
        }

        private void viewapplicants_Load(object sender, EventArgs e)
        {
           
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

        private void button2_Click(object sender, EventArgs e)
        {
            string ordb = "data source=orcl; user id=scott; password=tiger;";
            string cmdstr = "select applicants.name,applicants.ssn from applicants, applyfor where applicants.ssn=applyfor.ssn and applyfor.adnum=:n";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
