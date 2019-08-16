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
    public partial class updatejob : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public updatejob()
        {
            InitializeComponent();
        }

        private void updatejob_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select adnum from job";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);


            }
            dr.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from job where adnum=:id";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                opening.Text = dr[1].ToString();
                salary.Text = dr[2].ToString();
                workinghrs.Text = dr[3].ToString();
                role.Text = dr[4].ToString();
                degree.Text = dr[5].ToString();
                fieldstudy.Text = dr[6].ToString();
                field.Text = dr[7].ToString();
                experience.Text = dr[8].ToString();
                comp_id.Text = dr[9].ToString();


            }
            dr.Close();


        }
    }
}
