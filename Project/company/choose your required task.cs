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
    public partial class choose_your_required_task : Form
    {
        private string userSNN;
        public choose_your_required_task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2(userSNN);
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewapplicants bs = new viewapplicants();
            bs.Show();
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
    }
}
