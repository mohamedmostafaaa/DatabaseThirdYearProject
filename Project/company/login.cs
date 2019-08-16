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
    public partial class login : Form
    {
        string enteredtype;
        private string userSSN;
        private string enteredUsername;
        private string enteredPassword;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        private void login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteredUsername = textBox1.Text;
            enteredPassword = textBox2.Text;
            //MessageBox.Show(enteredUsername);
            //MessageBox.Show(enteredPassword);

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            if (enteredtype == "Applicants")
            {
                cmd.CommandText = "select * from applicants";
            }
            else if (enteredtype == "Company")
            {
                cmd.CommandText = "select * from company";
            }
            //  cmd.CommandText = "select * from applicants";
           // cmd.CommandType = CommandType.Text;
            userSSN = "";

          //  cmd.CommandText = "select * from applicants";
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (enteredUsername == dr[1].ToString() && enteredPassword == dr[4].ToString())
                {
                    userSSN = dr[0].ToString();
                    break;
                }
            }
            if (userSSN != "" && enteredtype == "Applicants")
            {
                //  MessageBox.Show(userSSN);
                applicant_home_page b = new applicant_home_page(userSSN);
                b.Show();
            }
            else if (userSSN != "" && enteredtype == "Company")
            {
                Form2 s = new Form2(userSSN);
                s.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            //button1.Enabled = false;
            //applicant_home_page b = new applicant_home_page();
            //b.Show(); */

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            enteredtype = "Applicants";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            enteredtype = "Company";
        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            start_screen_for_customer s = new start_screen_for_customer();
            s.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hanhzr ya 7abeby");
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*
 enteredUsername = textBox1.Text;
            enteredPassword = textBox2.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (enteredtype == "Applicants")
            {
                cmd.CommandText = "select * from applicants";
            }
            else if (enteredtype == "Company")
            {
                cmd.CommandText = "select * from company";
            }
            //  cmd.CommandText = "select * from applicants";
            cmd.CommandType = CommandType.Text;
            userSSN = "";

            OracleDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
               if (enteredUsername == dr[1].ToString() && enteredPassword == dr[4].ToString())
               {
                    userSSN = dr[0].ToString();
                    break;
               }
            }
            if (userSSN != "" && enteredtype == "Applicants")
            {            
                //  MessageBox.Show(userSSN);
                applicant_home_page b = new applicant_home_page(userSSN);
                b.Show();
            }
            else if (userSSN != "" && enteredtype == "Company")
            {
                Form2 s = new Form2(userSSN);
                s.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password"); 
            }
                //button1.Enabled = false;
                //applicant_home_page b = new applicant_home_page();
                //b.Show(); */
