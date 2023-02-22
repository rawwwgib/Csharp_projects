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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void screening_form_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo();
            ui.Show();
            ui.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void UserReport_Click(object sender, EventArgs e)
        {
            ps_eu.Visible = true;
            enter_ps_eu.Visible = true;
            submit_editUsers.Visible = true;
            if (submit_Report.Visible == true)
            {
                ps_sr.Clear();
                ps_sr.Visible = false;
                enter_ps_sr.Visible = false;
                submit_Report.Visible = false;
            }
        }

        private void exitMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportShow_Click(object sender, EventArgs e)
        {
            ps_sr.Visible = true;
            enter_ps_sr.Visible = true;
            submit_Report.Visible = true;
            if (submit_editUsers.Visible == true)
            {
                ps_eu.Clear();
                ps_eu.Visible = false;
                enter_ps_eu.Visible = false;
                submit_editUsers.Visible = false;
            }
        }

        private void submit_editUsers_Click(object sender, EventArgs e)
        {
            if (ps_eu.Text != "prg455")
            {
                MessageBox.Show("Incorrect Password (or maybe you aren't authorized)");
            }
            else
            {
                UserUpdate uu = new UserUpdate();
                uu.Show();
                uu.FormClosed += (s, args) => this.Close();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ps_sr.Text != "prg455")
            {
                MessageBox.Show("Incorrect Password (or maybe you aren't authorized)");
            }
            else
            {
                ScreeningReport sr = new ScreeningReport();
                sr.Show();
                sr.FormClosed += (s, args) => this.Close();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
