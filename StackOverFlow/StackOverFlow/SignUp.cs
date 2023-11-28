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
    public partial class SignUp : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            textBox5.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into UserInformation   values (UserID.nextval,:name,:gender,:phone,:email,:JoinDate )";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("gender", textBox4.Text);
            cmd.Parameters.Add("phone", textBox3.Text);
            cmd.Parameters.Add("email", textBox2.Text);
            cmd.Parameters.Add("JoinDate", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("New User Has Been Added");
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.Parameters.Add("Password", textBox6.Text);
            cmd2.Parameters.Add("JoinDate", textBox5.Text);
            cmd2.CommandText = "insert into AccountDetails values (Accountid.nextval,'User',0, :Password ,:JoinDate)";
            int r2 = cmd2.ExecuteNonQuery();
            if (r2 != -1)
                MessageBox.Show("New Account Has Been Added");
            UserInformation F = new UserInformation();
            F.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
