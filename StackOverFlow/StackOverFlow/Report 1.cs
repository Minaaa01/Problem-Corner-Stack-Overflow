using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StackOverFlow
{
    public partial class Report_1 : Form
    {
        CrystalReport1 CR;
        public Report_1()
        {
            InitializeComponent();
        }

        private void Report_1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
