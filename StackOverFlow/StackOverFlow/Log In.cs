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
    public partial class Log_In : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public Log_In()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM UserInformation , AccountDetails where username=:name and accpassword=:Password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Name", textBox1.Text);
            cmd.Parameters.Add("Password", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read() != false)
                MessageBox.Show("Login Successfully");
            else
                MessageBox.Show("Login Failed, Please Enter a vaild data...");
            dr.Close();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM UserInformation , AccountDetails where username=:name and accpassword=:Password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Name", textBox1.Text);
            cmd.Parameters.Add("Password", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read() != false)
            {
                GetAnswer F = new GetAnswer();
                F.Show();
              //  this.Visible = false; 
            }
            else
                MessageBox.Show("Please Login First...");
            dr.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM UserInformation , AccountDetails where username=:name and accpassword=:Password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Name", textBox1.Text);
            cmd.Parameters.Add("Password", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read() != false)
            {
                AddQuestion F = new AddQuestion();
                F.Show();
               // this.Visible = false;
            }
            else
                MessageBox.Show("Please Login First...");
            dr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM UserInformation , AccountDetails where username=:name and accpassword=:Password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Name", textBox1.Text);
            cmd.Parameters.Add("Password", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read() != false)
            {
                AddAnswer F = new AddAnswer();
                F.Show();
               // this.Visible = false;
            }
            else
                MessageBox.Show("Please Login First...");
            dr.Close();
        }
    }
}
