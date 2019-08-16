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
    
    public partial class Job_Report : Form
    {
        job jj;
        public Job_Report()
        {
            InitializeComponent();
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

        private void Job_Report_Load(object sender, EventArgs e)
        {
            jj = new job();
            foreach (ParameterDiscreteValue j in jj.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(j.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = jj;
            jj.SetParameterValue(0, comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
