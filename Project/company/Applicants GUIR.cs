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
    public partial class Applicants_GUIR : Form
    {
        applicants app;
        public Applicants_GUIR()
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

        private void Applicants_GUIR_Load(object sender, EventArgs e)
        {
            app = new applicants();
            foreach (ParameterDiscreteValue v in app.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
            foreach (ParameterDiscreteValue v in app.ParameterFields[1].DefaultValues)
                comboBox2.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = app;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            app.SetParameterValue(0, comboBox1.Text);
            app.SetParameterValue(1, comboBox2.Text);
        }
    }
}
