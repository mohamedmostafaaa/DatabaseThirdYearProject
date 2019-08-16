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
    public partial class start_screen_for_customer : Form
    {
        public start_screen_for_customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            the_new a = new the_new();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login hd = new login();
            hd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
