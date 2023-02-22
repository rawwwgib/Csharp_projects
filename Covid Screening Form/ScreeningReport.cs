using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TalaMohammedRagib
{
    public partial class ScreeningReport : Form
    {
        public ScreeningReport()
        {
            InitializeComponent();
        }

        private void ScreeningReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'screeningRecordsDataSet.combined' table. You can move, or remove it, as needed.
            this.combinedTableAdapter.Fill(this.screeningRecordsDataSet.combined);

        }

        private void search_Click(object sender, EventArgs e)
        {
            
            string fromDate = dateTimePicker1.Value.ToString();
            string to = dateTimePicker2.Value.ToString();
            this.combinedTableAdapter.FillBySearch(this.screeningRecordsDataSet.combined, nameSearch.Text, checkBox1.Checked.ToString(), fromDate, to);
        }

        private void home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            mf.Closed += (s, args) => this.Close();
            this.Hide();
    
        }

        
        
    }
}
