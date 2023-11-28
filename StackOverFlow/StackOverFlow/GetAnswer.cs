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
    public partial class GetAnswer : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public GetAnswer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl; User Id=hr; Password = hr;";
            string cmdstr = "select QuestionTitle ,AnswersBody from  Answers AN ,Question Q,AnswerQuestion AQ where  Q.QuestionID =AQ.QuestionID AND AN.AnswersID =AQ.AnswersID And Q.QuestionID=:QuestionID";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("QuestionID", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
