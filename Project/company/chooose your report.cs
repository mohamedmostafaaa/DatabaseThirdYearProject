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
    public partial class chooose_your_report : Form
    {
        public chooose_your_report()
        {
            InitializeComponent();
        }

        private void chooose_your_report_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Applicants_GUIR gu = new Applicants_GUIR();
            gu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Job_Report job = new Job_Report();
            job.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            companygui com = new companygui();
            com.Show();
        }
    }
}
