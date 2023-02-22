
namespace TalaMohammedRagib
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.screening_form = new System.Windows.Forms.Button();
            this.UserReport = new System.Windows.Forms.Button();
            this.reportShow = new System.Windows.Forms.Button();
            this.exitMainForm = new System.Windows.Forms.Button();
            this.ps_eu = new System.Windows.Forms.TextBox();
            this.ps_sr = new System.Windows.Forms.TextBox();
            this.enter_ps_eu = new System.Windows.Forms.Label();
            this.enter_ps_sr = new System.Windows.Forms.Label();
            this.submit_editUsers = new System.Windows.Forms.Button();
            this.submit_Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.Image = global::TalaMohammedRagib.Properties.Resources.Seneca_College_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-34, -38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 486);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // screening_form
            // 
            this.screening_form.Location = new System.Drawing.Point(154, 163);
            this.screening_form.Margin = new System.Windows.Forms.Padding(2);
            this.screening_form.Name = "screening_form";
            this.screening_form.Size = new System.Drawing.Size(98, 35);
            this.screening_form.TabIndex = 1;
            this.screening_form.Text = "Start Screening";
            this.screening_form.UseVisualStyleBackColor = true;
            this.screening_form.Click += new System.EventHandler(this.screening_form_Click);
            // 
            // UserReport
            // 
            this.UserReport.Location = new System.Drawing.Point(154, 223);
            this.UserReport.Margin = new System.Windows.Forms.Padding(2);
            this.UserReport.Name = "UserReport";
            this.UserReport.Size = new System.Drawing.Size(98, 35);
            this.UserReport.TabIndex = 2;
            this.UserReport.Text = "Edit Users  (Admin Only)";
            this.UserReport.UseVisualStyleBackColor = true;
            this.UserReport.Click += new System.EventHandler(this.UserReport_Click);
            // 
            // reportShow
            // 
            this.reportShow.Location = new System.Drawing.Point(154, 285);
            this.reportShow.Margin = new System.Windows.Forms.Padding(2);
            this.reportShow.Name = "reportShow";
            this.reportShow.Size = new System.Drawing.Size(98, 35);
            this.reportShow.TabIndex = 3;
            this.reportShow.Text = "Screening Report (Admin Only)";
            this.reportShow.UseVisualStyleBackColor = true;
            this.reportShow.Click += new System.EventHandler(this.reportShow_Click);
            // 
            // exitMainForm
            // 
            this.exitMainForm.Location = new System.Drawing.Point(316, 388);
            this.exitMainForm.Margin = new System.Windows.Forms.Padding(2);
            this.exitMainForm.Name = "exitMainForm";
            this.exitMainForm.Size = new System.Drawing.Size(76, 28);
            this.exitMainForm.TabIndex = 4;
            this.exitMainForm.Text = "Exit";
            this.exitMainForm.UseVisualStyleBackColor = true;
            this.exitMainForm.Click += new System.EventHandler(this.exitMainForm_Click);
            // 
            // ps_eu
            // 
            this.ps_eu.Location = new System.Drawing.Point(154, 262);
            this.ps_eu.Margin = new System.Windows.Forms.Padding(2);
            this.ps_eu.Name = "ps_eu";
            this.ps_eu.PasswordChar = '*';
            this.ps_eu.Size = new System.Drawing.Size(98, 20);
            this.ps_eu.TabIndex = 5;
            this.ps_eu.Visible = false;
            // 
            // ps_sr
            // 
            this.ps_sr.Location = new System.Drawing.Point(154, 325);
            this.ps_sr.Margin = new System.Windows.Forms.Padding(2);
            this.ps_sr.Name = "ps_sr";
            this.ps_sr.PasswordChar = '*';
            this.ps_sr.Size = new System.Drawing.Size(98, 20);
            this.ps_sr.TabIndex = 6;
            this.ps_sr.Visible = false;
            // 
            // enter_ps_eu
            // 
            this.enter_ps_eu.AutoSize = true;
            this.enter_ps_eu.Location = new System.Drawing.Point(28, 266);
            this.enter_ps_eu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enter_ps_eu.Name = "enter_ps_eu";
            this.enter_ps_eu.Size = new System.Drawing.Size(84, 13);
            this.enter_ps_eu.TabIndex = 7;
            this.enter_ps_eu.Text = "Enter Password:";
            this.enter_ps_eu.Visible = false;
            // 
            // enter_ps_sr
            // 
            this.enter_ps_sr.AutoSize = true;
            this.enter_ps_sr.Location = new System.Drawing.Point(28, 327);
            this.enter_ps_sr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enter_ps_sr.Name = "enter_ps_sr";
            this.enter_ps_sr.Size = new System.Drawing.Size(84, 13);
            this.enter_ps_sr.TabIndex = 8;
            this.enter_ps_sr.Text = "Enter Password:";
            this.enter_ps_sr.Visible = false;
            // 
            // submit_editUsers
            // 
            this.submit_editUsers.Location = new System.Drawing.Point(297, 262);
            this.submit_editUsers.Margin = new System.Windows.Forms.Padding(2);
            this.submit_editUsers.Name = "submit_editUsers";
            this.submit_editUsers.Size = new System.Drawing.Size(56, 19);
            this.submit_editUsers.TabIndex = 9;
            this.submit_editUsers.Text = "Submit";
            this.submit_editUsers.UseVisualStyleBackColor = true;
            this.submit_editUsers.Visible = false;
            this.submit_editUsers.Click += new System.EventHandler(this.submit_editUsers_Click);
            // 
            // submit_Report
            // 
            this.submit_Report.Location = new System.Drawing.Point(297, 323);
            this.submit_Report.Margin = new System.Windows.Forms.Padding(2);
            this.submit_Report.Name = "submit_Report";
            this.submit_Report.Size = new System.Drawing.Size(56, 19);
            this.submit_Report.TabIndex = 10;
            this.submit_Report.Text = "Submit";
            this.submit_Report.UseVisualStyleBackColor = true;
            this.submit_Report.Visible = false;
            this.submit_Report.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 442);
            this.Controls.Add(this.submit_Report);
            this.Controls.Add(this.submit_editUsers);
            this.Controls.Add(this.enter_ps_sr);
            this.Controls.Add(this.enter_ps_eu);
            this.Controls.Add(this.ps_sr);
            this.Controls.Add(this.ps_eu);
            this.Controls.Add(this.exitMainForm);
            this.Controls.Add(this.reportShow);
            this.Controls.Add(this.UserReport);
            this.Controls.Add(this.screening_form);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button screening_form;
        private System.Windows.Forms.Button UserReport;
        private System.Windows.Forms.Button reportShow;
        private System.Windows.Forms.Button exitMainForm;
        private System.Windows.Forms.TextBox ps_eu;
        private System.Windows.Forms.TextBox ps_sr;
        private System.Windows.Forms.Label enter_ps_eu;
        private System.Windows.Forms.Label enter_ps_sr;
        private System.Windows.Forms.Button submit_editUsers;
        private System.Windows.Forms.Button submit_Report;
    }
}