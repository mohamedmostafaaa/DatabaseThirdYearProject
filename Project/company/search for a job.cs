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
    public partial class search_for_a_job : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dataset;
        int index;
        DataGridViewRow selectedRow;
        OracleConnection conn;

        private string userssn;
        string adnum;
        string status = "Pending";
        string jobtitle;
        int appid;

        public search_for_a_job(string ssn)
        {
            this.userssn = ssn;
            InitializeComponent();
        }

        private void search_for_a_job_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            string cmdstr = "select * from job";

            adapter = new OracleDataAdapter(cmdstr, constr);
            dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            applicant_home_page home = new applicant_home_page(userssn);
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into APPLLICATION(APPID,MESSAGE,EMAIL,JOBTITLE,NAME,STATUS,ADNUM,SSN) values(:apid,:msg,:eml,:jtitle,:nm,:status,:adn,:ssn)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("apid", appid);
            cmd.Parameters.Add("msg", textBox1.Text);
            cmd.Parameters.Add("eml", textBox2.Text);
            cmd.Parameters.Add("jtitle", jobtitle);
            cmd.Parameters.Add("nm", textBox3.Text);
            cmd.Parameters.Add("status", status);
            cmd.Parameters.Add("adn", adnum);
            cmd.Parameters.Add("ssn", userssn);

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "insert into APPLYFOR(SSN, ADNUM) values(:cssn,:cAdnum)";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("cssn", userssn);
            


            appid--;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "update job set opening = :setappid where adnum = :setappid2";
            cmd3.Parameters.Add("cAdnum", adnum);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("setappid", appid);
            cmd2.Parameters.Add("setappid2", adnum);


           // textBox3.Text = appid.ToString();

            int r = cmd.ExecuteNonQuery();
            int z = cmd2.ExecuteNonQuery();
            int y = cmd3.ExecuteNonQuery();
            button1.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            selectedRow = dataGridView1.Rows[index];
            adnum = selectedRow.Cells[0].Value.ToString();
            jobtitle = selectedRow.Cells[6].Value.ToString();
            appid = Convert.ToInt32(selectedRow.Cells[1].Value);
            textBox5.Text = adnum;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
