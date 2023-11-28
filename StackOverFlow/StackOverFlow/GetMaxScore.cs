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
    public partial class GetMaxScore : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public GetMaxScore()
        {
            InitializeComponent();
        }

        private void GetMaxScore_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMaxScore";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MaxScore", OracleDbType.Int32, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            max = Convert.ToInt32(cmd.Parameters["MaxScore"].Value.ToString());
            textBox2.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
