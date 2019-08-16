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
    public partial class offerjob : Form
    {
       // string userSSN;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public offerjob()
        {
            InitializeComponent();
        }

        private void offerjob_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into job values (:adnum,:opening,:salary,:role,:workinghours,:field,:degree,:fieldofstudy,:experience,:comp)";
            cmd.Parameters.Add("adnum", Adnum.Text);
            cmd.Parameters.Add("opening", opening.Text);
            cmd.Parameters.Add("salary", salary.Text);
            cmd.Parameters.Add("role", role.Text);
            cmd.Parameters.Add("workinghours", workinghrs.Text);
            cmd.Parameters.Add("field", field.Text);
            cmd.Parameters.Add("degree", degree.Text);
            cmd.Parameters.Add("fieldofstudy", fieldstudy.Text);
            cmd.Parameters.Add("experience", experience.Text);
            cmd.Parameters.Add("comp", comp_id.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New job is added");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
