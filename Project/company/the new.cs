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
    public partial class the_new : Form
    {
        public the_new()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration w = new registration();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 z = new Form1();
            z.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.25; }
            else
            { timer1.Stop(); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
