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
    public partial class UserUpdate : Form
    {
        public UserUpdate()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.screeningRecordsDataSet);

        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'screeningRecordsDataSet.Screening' table. You can move, or remove it, as needed.
            this.screeningTableAdapter.Fill(this.screeningRecordsDataSet.Screening);
            // TODO: This line of code loads data into the 'screeningRecordsDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.screeningRecordsDataSet.User);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.screeningRecordsDataSet);
        }

        private void home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            mf.Closed += (s,args) => this.Close();
            this.Hide();
        }
    }
}
