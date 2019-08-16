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
    public partial class update_CV : Form
    {
       private string userSSN;
        public update_CV(string user)
        {
            this.userSSN = user;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Degree d = new Add_Degree(userSSN);
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previous_job j = new previous_job(userSSN);
            j.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            {
                timer1.Stop();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
