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
    public partial class ScreeningForm : Form
    {
        public ScreeningForm()
        {
            InitializeComponent();
        }
        public static string closeContact;
        public static string travelled;
        public static string symptoms;
        public static string date;

        private void ScreeningForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'screeningRecordsDataSet.Screening' table. You can move, or remove it, as needed.
            this.screeningTableAdapter.Fill(this.screeningRecordsDataSet.Screening);
            Question1.Text = "Have you been in close contact with a person who got recently diagonized with COVID-19?";
            Question2.Text = "Have you travelled outside of Ontario or been with contact with a person who travelled outside within the last 14 days?";
            Question3.Text = "Do you have any Covid symptoms like cough, cold, fever or loss of smell?";

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAnswers_Click(object sender, EventArgs e)
        {
            closeContact = Answer1.SelectedItem.ToString();
            travelled = Answer2.SelectedItem.ToString();
            symptoms = Answer3.SelectedItem.ToString();
            date = dateTimePicker1.Value.ToString();
           
            if(closeContact == "Yes" || travelled == "Yes" || symptoms == "Yes")
            {
                this.userTableAdapter.FlaggedUpdate("True", UserInfo.userID);
              //  this.userTableAdapter.FlaggedUpdate(true, MainForm.userID);
                this.screeningTableAdapter.AddReport(UserInfo.userID, closeContact, travelled, symptoms, date);
                UserInfo mf = new UserInfo();
                mf.Show();
                mf.Closed += (s, args) => this.Close();
                this.Hide();
               
            }
            else
            {
                this.userTableAdapter.FlaggedUpdate("False", UserInfo.userID);
                this.screeningTableAdapter.AddReport(UserInfo.userID, closeContact, travelled, symptoms,date);
                UserInfo mf = new UserInfo();
                mf.Show();
                mf.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }
    }
}
