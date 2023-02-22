
namespace TalaMohammedRagib
{
    partial class ScreeningForm
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
            this.Question1 = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.ComboBox();
            this.Answer2 = new System.Windows.Forms.ComboBox();
            this.Answer3 = new System.Windows.Forms.ComboBox();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.SaveAnswers = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.screeningTableAdapter = new TalaMohammedRagib.ScreeningRecordsDataSetTableAdapters.ScreeningTableAdapter();
            this.tableAdapterManager = new TalaMohammedRagib.ScreeningRecordsDataSetTableAdapters.TableAdapterManager();
            this.userTableAdapter = new TalaMohammedRagib.ScreeningRecordsDataSetTableAdapters.UserTableAdapter();
            this.screeningRecordsDataSet = new TalaMohammedRagib.ScreeningRecordsDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screeningRecordsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(65, 76);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(52, 17);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "label1";
            // 
            // Answer1
            // 
            this.Answer1.FormattingEnabled = true;
            this.Answer1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Answer1.Location = new System.Drawing.Point(68, 118);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(121, 24);
            this.Answer1.TabIndex = 1;
            // 
            // Answer2
            // 
            this.Answer2.FormattingEnabled = true;
            this.Answer2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Answer2.Location = new System.Drawing.Point(68, 219);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(121, 24);
            this.Answer2.TabIndex = 2;
            // 
            // Answer3
            // 
            this.Answer3.FormattingEnabled = true;
            this.Answer3.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Answer3.Location = new System.Drawing.Point(68, 328);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(121, 24);
            this.Answer3.TabIndex = 3;
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.Location = new System.Drawing.Point(65, 178);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(52, 17);
            this.Question2.TabIndex = 4;
            this.Question2.Text = "label1";
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3.Location = new System.Drawing.Point(65, 286);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(52, 17);
            this.Question3.TabIndex = 5;
            this.Question3.Text = "label1";
            // 
            // SaveAnswers
            // 
            this.SaveAnswers.Location = new System.Drawing.Point(329, 532);
            this.SaveAnswers.Name = "SaveAnswers";
            this.SaveAnswers.Size = new System.Drawing.Size(119, 33);
            this.SaveAnswers.TabIndex = 8;
            this.SaveAnswers.Text = "Continue";
            this.SaveAnswers.UseVisualStyleBackColor = true;
            this.SaveAnswers.Click += new System.EventHandler(this.SaveAnswers_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(623, 532);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // screeningTableAdapter
            // 
            this.screeningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScreeningTableAdapter = this.screeningTableAdapter;
            this.tableAdapterManager.UpdateOrder = TalaMohammedRagib.ScreeningRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // screeningRecordsDataSet
            // 
            this.screeningRecordsDataSet.DataSetName = "ScreeningRecordsDataSet";
            this.screeningRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 440);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date";
            // 
            // ScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1049, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveAnswers);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question1);
            this.Name = "ScreeningForm";
            this.Text = "ScreeningForm";
            this.Load += new System.EventHandler(this.ScreeningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screeningRecordsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.ComboBox Answer1;
        private System.Windows.Forms.ComboBox Answer2;
        private System.Windows.Forms.ComboBox Answer3;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.Button SaveAnswers;
        private System.Windows.Forms.Button Exit;
        private ScreeningRecordsDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
        private ScreeningRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ScreeningRecordsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private ScreeningRecordsDataSet screeningRecordsDataSet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}