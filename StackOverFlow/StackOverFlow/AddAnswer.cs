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
    public partial class AddAnswer : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public AddAnswer()
        {
            InitializeComponent();
        }

        private void AddAnswer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            textBox2.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Answers  values (:AnswersID  ,:AnswersBody  ,:ReleaseDate )";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("AnswersID", textBox4.Text);
            cmd.Parameters.Add("AnswersBody", textBox3.Text);
            cmd.Parameters.Add("ReleaseDate", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("New Answer Added Successfully");

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.Parameters.Add("QuestionID", textBox1.Text);
            cmd2.Parameters.Add("AnswersID", textBox4.Text);
            cmd2.CommandText = "insert into AnswerQuestion values (:QuestionID ,:AnswersID)";
            int r2 = cmd2.ExecuteNonQuery();
            if (r2 != -1)
                MessageBox.Show("New Answer Saved Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Log_In F = new Log_In();
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
