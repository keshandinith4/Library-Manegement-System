namespace Library_Manegement_System
{
    partial class Dashboard
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
            this.bookbtn = new System.Windows.Forms.Button();
            this.memberbtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookbtn
            // 
            this.bookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bookbtn.Location = new System.Drawing.Point(40, 74);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(101, 49);
            this.bookbtn.TabIndex = 0;
            this.bookbtn.Text = "Books";
            this.bookbtn.UseVisualStyleBackColor = false;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // memberbtn
            // 
            this.memberbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.memberbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberbtn.Location = new System.Drawing.Point(158, 74);
            this.memberbtn.Name = "memberbtn";
            this.memberbtn.Size = new System.Drawing.Size(101, 49);
            this.memberbtn.TabIndex = 1;
            this.memberbtn.Text = "Members";
            this.memberbtn.UseVisualStyleBackColor = false;
            this.memberbtn.Click += new System.EventHandler(this.memberbtn_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.Location = new System.Drawing.Point(279, 74);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(101, 49);
            this.reportbtn.TabIndex = 2;
            this.reportbtn.Text = "Reports";
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.Location = new System.Drawing.Point(309, 144);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(71, 28);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to Dashbord!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Developed By Keshan Jayaweera";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.memberbtn);
            this.Controls.Add(this.bookbtn);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookbtn;
        private System.Windows.Forms.Button memberbtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}