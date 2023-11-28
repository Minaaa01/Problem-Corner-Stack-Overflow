using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace StackOverFlow
{
    public partial class Show_System_Groups : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        public Show_System_Groups()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl; User Id=hr; Password = hr;";
            string cmdstr = "select GroupID , GroupName ,GroupDescription,NumberOFMembers from CreateGroup  where GroupID =:GroupID ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("GroupID", textBox2.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
