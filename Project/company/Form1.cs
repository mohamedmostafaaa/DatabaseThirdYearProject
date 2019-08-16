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
    public partial class Form1 : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
      
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into company values (:id,:name,:location,:fieldofbussiness,:password,:Username)";
            cmd.Parameters.Add("id",textBox4.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("location", textBox6.Text);
            cmd.Parameters.Add("fieldofbussiness", textBox4.Text);
            cmd.Parameters.Add("password", textBox5.Text);
            cmd.Parameters.Add("Username", textBox3.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New company is added");
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.25; }
            else
            { timer1.Stop(); }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
