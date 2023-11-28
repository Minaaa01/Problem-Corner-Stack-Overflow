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
    public partial class StackOverFlow : Form
    {
        public StackOverFlow()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp F = new SignUp();
            F.Show();
            this.Visible = false;
        }

        private void showAllAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_All_Admins F = new Show_All_Admins();
            F.Show();
            this.Visible = false;
        }

        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_All_Users F = new Show_All_Users();
            F.Show();
            this.Visible = false;
        }

        private void getMaxScoreForUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMaxScore F = new GetMaxScore();
            F.Show();
            this.Visible = false;
        }

        private void showSystemGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_System_Groups F = new Show_System_Groups();
            F.Show();
            this.Visible = false;
        }

        private void getAnswerForQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login First...");
            Log_In F = new Log_In();
            F.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_1 F = new Report_1();
            F.Show();
            this.Visible = false;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_In F = new Log_In();
            F.Show();
            this.Visible = false;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void answersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CReport_2 F = new CReport_2();
            F.Show();
            this.Visible = false;
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login First...");
            Log_In F = new Log_In();
            F.Show();
            this.Visible = false;
        }

        private void addAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login First...");
            Log_In F = new Log_In();
            F.Show();
            this.Visible = false;
        }

        private void showAllUsersInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation F = new UserInformation();
            F.Show();
            this.Visible = false;
        }

    }
}
