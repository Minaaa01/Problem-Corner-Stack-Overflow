﻿using System;
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
    public partial class Show_All_Users : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password = hr;";
        OracleConnection conn;
        public Show_All_Users()
        {
            InitializeComponent();
        }

        private void Show_All_Users_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllUsers";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("users", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                comboBox1.Items.Add(rd[0]);
            rd.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StackOverFlow F = new StackOverFlow();
            F.Show();
        }
    }
}
