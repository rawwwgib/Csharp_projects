
namespace TalaMohammedRagib
{
    partial class UserInfo
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
            this.UserID = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.Label();
            this.Proceed = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.UserIdTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.UserTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userTableAdapter = new TalaMohammedRagib.ScreeningRecordsDataSetTableAdapters.UserTableAdapter();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(44, 96);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(46, 13);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "UserID";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(44, 137);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(63, 13);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Username";
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.Location = new System.Drawing.Point(44, 180);
            this.UserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(65, 13);
            this.UserType.TabIndex = 2;
            this.UserType.Text = "User Type";
            // 
            // Proceed
            // 
            this.Proceed.Location = new System.Drawing.Point(100, 297);
            this.Proceed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(68, 26);
            this.Proceed.TabIndex = 3;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.PowderBlue;
            this.exit.Location = new System.Drawing.Point(206, 297);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 26);
            this.exit.TabIndex = 4;
            this.exit.Text = "Home";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // UserIdTxtBox
            // 
            this.UserIdTxtBox.Location = new System.Drawing.Point(170, 93);
            this.UserIdTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserIdTxtBox.Name = "UserIdTxtBox";
            this.UserIdTxtBox.Size = new System.Drawing.Size(117, 20);
            this.UserIdTxtBox.TabIndex = 5;
            this.UserIdTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTxtBox_KeyPress);
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Location = new System.Drawing.Point(170, 137);
            this.UserNameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(117, 20);
            this.UserNameTxtBox.TabIndex = 6;
            // 
            // UserTypeCombo
            // 
            this.UserTypeCombo.FormattingEnabled = true;
            this.UserTypeCombo.Items.AddRange(new object[] {
            "Student",
            "Employee"});
            this.UserTypeCombo.Location = new System.Drawing.Point(170, 180);
            this.UserTypeCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserTypeCombo.Name = "UserTypeCombo";
            this.UserTypeCombo.Size = new System.Drawing.Size(117, 21);
            this.UserTypeCombo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Info";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(364, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserTypeCombo);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.UserIdTxtBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInfo";
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserType;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox UserIdTxtBox;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.ComboBox UserTypeCombo;
        private ScreeningRecordsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

