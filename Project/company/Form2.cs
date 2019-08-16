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
    public partial class Form2 : Form
    {
        private string userSSN;

        public Form2(string userSSN)
        {
            this.userSSN = userSSN;
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            offerjob h = new offerjob();
            h.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatejob j = new updatejob();
            j.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remove_job ja = new remove_job();
            ja.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
