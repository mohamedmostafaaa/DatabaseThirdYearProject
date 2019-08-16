using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace company
{
    public partial class companygui : Form
    {
        company comm;
        public companygui()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            { this.Opacity -= 0.025; }
            else
            { timer1.Stop(); }
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
        private void companygui_Load(object sender, EventArgs e)
        {
            comm = new company();
            foreach (ParameterDiscreteValue n in comm.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(n.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comm.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = comm;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
