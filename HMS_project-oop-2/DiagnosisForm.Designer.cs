
namespace HMS_project_oop_2
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DocFormExit = new System.Windows.Forms.Label();
            this.Symptoms = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatID = new System.Windows.Forms.TextBox();
            this.DiagID = new System.Windows.Forms.TextBox();
            this.Diagnosis = new System.Windows.Forms.TextBox();
            this.Medicines = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(495, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIAGNOSIS";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.DocFormExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 100);
            this.panel1.TabIndex = 1;
            // 
            // DocFormExit
            // 
            this.DocFormExit.AutoSize = true;
            this.DocFormExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocFormExit.ForeColor = System.Drawing.Color.Crimson;
            this.DocFormExit.Location = new System.Drawing.Point(1195, 9);
            this.DocFormExit.Name = "DocFormExit";
            this.DocFormExit.Size = new System.Drawing.Size(28, 30);
            this.DocFormExit.TabIndex = 13;
            this.DocFormExit.Text = "X";
            this.DocFormExit.Click += new System.EventHandler(this.DocFormExit_Click);
            // 
            // Symptoms
            // 
            this.Symptoms.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Symptoms.Location = new System.Drawing.Point(67, 283);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(184, 25);
            this.Symptoms.TabIndex = 8;
            this.Symptoms.Text = "Symptoms";
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatName.Location = new System.Drawing.Point(67, 236);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(184, 25);
            this.PatName.TabIndex = 7;
            this.PatName.Text = "PatientName";
            // 
            // PatID
            // 
            this.PatID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatID.Location = new System.Drawing.Point(67, 190);
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(184, 25);
            this.PatID.TabIndex = 6;
            this.PatID.Text = "PatientID";
            // 
            // DiagID
            // 
            this.DiagID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagID.Location = new System.Drawing.Point(67, 142);
            this.DiagID.Name = "DiagID";
            this.DiagID.Size = new System.Drawing.Size(184, 25);
            this.DiagID.TabIndex = 5;
            this.DiagID.Text = "DiagnosisID";
            // 
            // Diagnosis
            // 
            this.Diagnosis.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diagnosis.Location = new System.Drawing.Point(67, 328);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(184, 25);
            this.Diagnosis.TabIndex = 9;
            this.Diagnosis.Text = "Diagnosis";
            // 
            // Medicines
            // 
            this.Medicines.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Medicines.Location = new System.Drawing.Point(67, 372);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(184, 25);
            this.Medicines.TabIndex = 10;
            this.Medicines.Text = "Medicines";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(118, 503);
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
            this.button3.Location = new System.Drawing.Point(214, 438);
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
            this.button2.Location = new System.Drawing.Point(118, 438);
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
            this.button1.Location = new System.Drawing.Point(18, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Location = new System.Drawing.Point(366, 214);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowTemplate.Height = 25;
            this.DiagnosisGV.Size = new System.Drawing.Size(808, 440);
            this.DiagnosisGV.TabIndex = 15;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1116, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(920, 133);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(179, 23);
            this.SearchTb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cyberdyne", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(665, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "DIAGNOSIS LIST";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1219, 666);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.Symptoms);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatID);
            this.Controls.Add(this.DiagID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DocFormExit;
        private System.Windows.Forms.TextBox Symptoms;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatID;
        private System.Windows.Forms.TextBox DiagID;
        private System.Windows.Forms.TextBox Diagnosis;
        private System.Windows.Forms.TextBox Medicines;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Label label3;
    }
}