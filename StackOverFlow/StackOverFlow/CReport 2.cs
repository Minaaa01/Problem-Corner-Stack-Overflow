using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace StackOverFlow
{
    public partial class CReport_2 : Form
    {
        Report_2 CR;
        public CReport_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text); // index , value
            crystalReportViewer1.ReportSource = CR;
        }

        private void CReport_2_Load(object sender, EventArgs e)
        {
            CR = new Report_2();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
