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
    public partial class display_recommended : Form
    {
        int index;
        DataGridViewRow selectedRow;
        OracleConnection conn;
        string adnum;
        string status = "Pending";
        string jobtitle;
        int appid;

       // string admun;
        string constr;
        private string userSSN;
        OracleDataAdapter adapter;
        OracleCommandBuilder buider;
        DataSet set;
        string ordb = "data source = orcl ;user id = scott ; password = tiger ;";

        public display_recommended(string userSSN)
        {
            this.userSSN = userSSN;
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            update_CV up = new update_CV(userSSN);
            up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            applicant_home_page home = new applicant_home_page(userSSN);
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdstr = "";
            cmdstr = "select * from cv, job where cv.degreeofeducation = job.degre ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            set = new DataSet();
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            textBox4.Text = adnum;
            textBox5.Text = appid.ToString();
            textBox6.Text = jobtitle;
            textBox7.Text = userSSN;
        }

        private void display_recommended_Load(object sender, EventArgs e)
        {
             constr = "data source = orcl; user id = scott ; password = tiger ;";
           
            textBox4.Text = adnum;
            textBox5.Text = appid.ToString();
            textBox6.Text = jobtitle;
            textBox7.Text = userSSN;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            selectedRow = dataGridView1.Rows[index];
            adnum = selectedRow.Cells[2].Value.ToString();
            jobtitle = selectedRow.Cells[8].Value.ToString();
            appid = Convert.ToInt32(selectedRow.Cells[3].Value);
            textBox4.Text = adnum;
            textBox5.Text = appid.ToString();
            textBox6.Text = jobtitle;
            textBox7.Text = userSSN;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //// ============================================================================
            /// applay for table 

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into APPLYFOR (SSN, ADNUM) values (:cssn, :cAdnum)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("cssn", userSSN);
            cmd.Parameters.Add("cAdnum", adnum);
            
           

            /////=============================================================================
            /// applciation table  
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "insert into APPLLICATION(APPID,MESSAGE,EMAIL,JOBTITLE,NAME,STATUS,ADNUM,SSN) values(:apid,:msg,:eml,:jtitle,:nm,:status,:adn,:ssn)";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("apid", appid);
            cmd1.Parameters.Add("msg", textBox1.Text);
            cmd1.Parameters.Add("eml", textBox2.Text);
            cmd1.Parameters.Add("jtitle", jobtitle);
            cmd1.Parameters.Add("nm", textBox3.Text);
            cmd1.Parameters.Add("status", status);
            cmd1.Parameters.Add("adn", adnum);
            cmd1.Parameters.Add("ssn", userSSN);
            MessageBox.Show("done");
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            textBox4.Text = adnum;
            textBox5.Text = appid.ToString();
            textBox6.Text = jobtitle;
            textBox7.Text = userSSN;

            appid--;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "update job set opening = :setappid where adnum = :setappid2";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("setappid", appid);
            cmd2.Parameters.Add("setappid2", adnum);

        }
    }
}
