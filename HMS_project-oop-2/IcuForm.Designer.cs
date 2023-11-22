
namespace HMS_project_oop_2
{
    partial class IcuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IcuForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IcuFormExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IcuStatus = new System.Windows.Forms.TextBox();
            this.IcuNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.DocName = new System.Windows.Forms.TextBox();
            this.IcuGV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcuGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(542, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "I.C.U";
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
            this.panel1.Controls.Add(this.IcuFormExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 100);
            this.panel1.TabIndex = 2;
            // 
            // IcuFormExit
            // 
            this.IcuFormExit.AutoSize = true;
            this.IcuFormExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IcuFormExit.ForeColor = System.Drawing.Color.Crimson;
            this.IcuFormExit.Location = new System.Drawing.Point(1161, 9);
            this.IcuFormExit.Name = "IcuFormExit";
            this.IcuFormExit.Size = new System.Drawing.Size(28, 30);
            this.IcuFormExit.TabIndex = 14;
            this.IcuFormExit.Text = "X";
            this.IcuFormExit.Click += new System.EventHandler(this.IcuFormExit_Click);
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
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(122, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 45);
            this.button4.TabIndex = 21;
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
            this.button3.Location = new System.Drawing.Point(218, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 45);
            this.button3.TabIndex = 20;
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
            this.button2.Location = new System.Drawing.Point(122, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 45);
            this.button2.TabIndex = 19;
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
            this.button1.Location = new System.Drawing.Point(22, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IcuStatus
            // 
            this.IcuStatus.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IcuStatus.Location = new System.Drawing.Point(73, 229);
            this.IcuStatus.Name = "IcuStatus";
            this.IcuStatus.Size = new System.Drawing.Size(184, 25);
            this.IcuStatus.TabIndex = 24;
            this.IcuStatus.Text = "I.C.U Status";
            // 
            // IcuNumber
            // 
            this.IcuNumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IcuNumber.Location = new System.Drawing.Point(73, 197);
            this.IcuNumber.Name = "IcuNumber";
            this.IcuNumber.Size = new System.Drawing.Size(184, 25);
            this.IcuNumber.TabIndex = 23;
            this.IcuNumber.Text = "I.C.U NO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(759, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "I.C.U";
            // 
            // DocPass
            // 
            this.DocPass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocPass.Location = new System.Drawing.Point(73, 293);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(184, 25);
            this.DocPass.TabIndex = 26;
            this.DocPass.Text = "Doctor Password";
            // 
            // DocName
            // 
            this.DocName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocName.Location = new System.Drawing.Point(73, 261);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(184, 25);
            this.DocName.TabIndex = 27;
            this.DocName.Text = "Doctor Name";
            // 
            // IcuGV
            // 
            this.IcuGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.IcuGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IcuGV.Location = new System.Drawing.Point(383, 169);
            this.IcuGV.Name = "IcuGV";
            this.IcuGV.RowTemplate.Height = 25;
            this.IcuGV.Size = new System.Drawing.Size(808, 440);
            this.IcuGV.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1109, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(913, 116);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(179, 23);
            this.SearchTb.TabIndex = 29;
            // 
            // IcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1203, 666);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.IcuGV);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IcuStatus);
            this.Controls.Add(this.IcuNumber);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IcuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IcuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcuGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IcuStatus;
        private System.Windows.Forms.TextBox IcuNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.Label IcuFormExit;
        private System.Windows.Forms.DataGridView IcuGV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchTb;
    }
}