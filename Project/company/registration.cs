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
    public partial class registration : Form
    {
        private string userSSN;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
       
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registration_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into applicants values (:ssn,:name,:address,:age,:password)";
            cmd.Parameters.Add("ssn", textBox9.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("address", textBox4.Text);
            cmd.Parameters.Add("age", textBox10.Text);
            cmd.Parameters.Add("password", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New user is added");
                applicant_home_page ap = new applicant_home_page(userSSN);
                ap.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            the_new N = new the_new();
            N.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
