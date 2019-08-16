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
    public partial class previous_job : Form
    {
        private string userSSN;
        string ordb = "data source = orcl; user id = scott ;password = tiger;";
        OracleConnection conn;
        public previous_job(string ssn)
        {
            this.userSSN = ssn;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cvpreviousjob values (:ssn,:comp,:role,:experience)";
            cmd.Parameters.Add("ssn", userSSN);
            cmd.Parameters.Add("comp", textBox1.Text);
            cmd.Parameters.Add("role", textBox2.Text);
            cmd.Parameters.Add("experience", textBox3.Text);

            int r = cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Added Previous Job !");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.25; }
            else
            {
                timer1.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void previous_job_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
