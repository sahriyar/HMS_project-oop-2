﻿
namespace HMS_project_oop_2
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatID = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatAdd = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.BloodCb = new System.Windows.Forms.ComboBox();
            this.PatDisease = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 100);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(1195, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(495, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatID
            // 
            this.PatID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatID.Location = new System.Drawing.Point(80, 177);
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(184, 22);
            this.PatID.TabIndex = 2;
            this.PatID.Text = "PatID";
            this.PatID.TextChanged += new System.EventHandler(this.PatientID_TextChanged);
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatName.Location = new System.Drawing.Point(80, 209);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(184, 22);
            this.PatName.TabIndex = 3;
            this.PatName.Text = "PatientName";
            this.PatName.TextChanged += new System.EventHandler(this.PatName_TextChanged);
            // 
            // PatAdd
            // 
            this.PatAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatAdd.Location = new System.Drawing.Point(80, 241);
            this.PatAdd.Name = "PatAdd";
            this.PatAdd.Size = new System.Drawing.Size(184, 22);
            this.PatAdd.TabIndex = 4;
            this.PatAdd.Text = "PatientAddress";
            this.PatAdd.TextChanged += new System.EventHandler(this.PatAd_TextChanged);
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatPhone.Location = new System.Drawing.Point(80, 273);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(184, 22);
            this.PatPhone.TabIndex = 5;
            this.PatPhone.Text = "PatientPhone";
            // 
            // PatAge
            // 
            this.PatAge.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatAge.Location = new System.Drawing.Point(80, 305);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(184, 22);
            this.PatAge.TabIndex = 6;
            this.PatAge.Text = "PatientAge";
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(80, 337);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(184, 25);
            this.GenderCb.TabIndex = 7;
            this.GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            this.BloodCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodCb.FormattingEnabled = true;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.BloodCb.Location = new System.Drawing.Point(80, 368);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(184, 25);
            this.BloodCb.TabIndex = 8;
            this.BloodCb.Text = "BloodGroup";
            // 
            // PatDisease
            // 
            this.PatDisease.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatDisease.Location = new System.Drawing.Point(80, 399);
            this.PatDisease.Name = "PatDisease";
            this.PatDisease.Size = new System.Drawing.Size(184, 22);
            this.PatDisease.TabIndex = 9;
            this.PatDisease.Text = "MajorDisease";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(127, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 45);
            this.button4.TabIndex = 14;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(223, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(127, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(27, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cyberdyne", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(673, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "PATIENT LIST";
            // 
            // PatientGV
            // 
            this.PatientGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(377, 172);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowTemplate.Height = 25;
            this.PatientGV.Size = new System.Drawing.Size(808, 440);
            this.PatientGV.TabIndex = 16;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1148, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(952, 122);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(179, 23);
            this.SearchTb.TabIndex = 17;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1235, 705);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatDisease);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatAdd);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatID;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatAdd;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox BloodCb;
        private System.Windows.Forms.TextBox PatDisease;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchTb;
    }
}