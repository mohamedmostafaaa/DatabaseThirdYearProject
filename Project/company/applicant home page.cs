using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class applicant_home_page : Form
    {
        string userssn; 
        public applicant_home_page(string ssn)
        {
            this.userssn = ssn; 
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_for_a_job a = new search_for_a_job(userssn);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            update_CV cc = new update_CV(userssn);
            cc.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            check_pending p = new check_pending(userssn);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display_recommended dR = new display_recommended(userssn);
            dR.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display_user_app dR = new display_user_app(userssn);
            dR.Show();
        }
    }
}
