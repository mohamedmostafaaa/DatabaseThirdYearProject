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
    public partial class Add_Degree : Form
    {
        string userSSN;
        OracleConnection conn;

        string ordb = "data source = orcl ; user id = scott ; password = tiger;";
        public Add_Degree(string userSSN)
        {
            this.userSSN = userSSN;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into cv values (:ssn , :name)";
            cmd.Parameters.Add("ssn",userSSN);
            cmd.Parameters.Add("name", textBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("CV is added");
            }
        }

        private void Add_Degree_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            { this.Opacity -= 0.25; }
            else
            {
                timer1.Stop();
              //  Application.Exit();
            }
        }
    }
}
