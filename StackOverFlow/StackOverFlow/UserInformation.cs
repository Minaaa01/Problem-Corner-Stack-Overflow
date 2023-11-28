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
    public partial class UserInformation : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select UserID  from UserInformation";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select UserName , gender ,AccountRole, score ,LastActivityDate  FROM UserInformation ,AccountDetails where  UserID = Accountid  and  UserID =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // while or if
            {
                textBox1.Text = dr[0].ToString();
                textBox4.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox5.Text = dr[3].ToString();
                textBox6.Text = dr[4].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
