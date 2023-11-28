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
    public partial class AddQuestion : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            textBox2.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Question   values (:QuestionID ,:QuestionTitle ,:QuestionBody ,:ReleaseDate )";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("QuestionID", textBox1.Text);
            cmd.Parameters.Add("QuestionTitle", textBox4.Text);
            cmd.Parameters.Add("QuestionBody", textBox3.Text);
            cmd.Parameters.Add("ReleaseDate", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("New Question Added Successfully");
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
