using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalaMohammedRagib
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        public static int userID;
        public static string userName;
        public static string userType;

        private void exit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            mf.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void Proceed_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt64(UserIdTxtBox.Text) <= 9999999 && Convert.ToInt64(UserIdTxtBox.Text) >= 1000000000)
                MessageBox.Show("Enter a valid 9 digit id");
            else
            {
                userID = (int) Convert.ToInt64(UserIdTxtBox.Text);
                userName = UserNameTxtBox.Text;
                userType = UserTypeCombo.SelectedItem.ToString();
                this.userTableAdapter.AddUser(userID, userName, userType);

                ScreeningForm sf = new ScreeningForm();
                sf.Show();
                sf.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }

        private void UserIdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate();
            userUpdate.Show();
            userUpdate.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void screeningReport_Click(object sender, EventArgs e)
        {
            ScreeningReport sr = new ScreeningReport();
            sr.Show();
            sr.Closed += (s, args) => this.Close();
            this.Hide();
        }

       
    }
}
