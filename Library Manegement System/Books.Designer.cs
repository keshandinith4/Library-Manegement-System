namespace Library_Manegement_System
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.managebookbtn = new System.Windows.Forms.Button();
            this.issuebooksbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Library Management System";
            // 
            // managebookbtn
            // 
            this.managebookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.managebookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managebookbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.managebookbtn.Location = new System.Drawing.Point(40, 53);
            this.managebookbtn.Name = "managebookbtn";
            this.managebookbtn.Size = new System.Drawing.Size(101, 49);
            this.managebookbtn.TabIndex = 6;
            this.managebookbtn.Text = "Manage Books";
            this.managebookbtn.UseVisualStyleBackColor = false;
            this.managebookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // issuebooksbtn
            // 
            this.issuebooksbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.issuebooksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebooksbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.issuebooksbtn.Location = new System.Drawing.Point(147, 53);
            this.issuebooksbtn.Name = "issuebooksbtn";
            this.issuebooksbtn.Size = new System.Drawing.Size(101, 49);
            this.issuebooksbtn.TabIndex = 7;
            this.issuebooksbtn.Text = "Issue Books";
            this.issuebooksbtn.UseVisualStyleBackColor = false;
            this.issuebooksbtn.Click += new System.EventHandler(this.issuebooksbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(254, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Return Books";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.Location = new System.Drawing.Point(284, 119);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(71, 28);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(207, 119);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(71, 28);
            this.backbtn.TabIndex = 10;
            this.backbtn.Text = "< Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Developed By Keshan Jayaweera";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.issuebooksbtn);
            this.Controls.Add(this.managebookbtn);
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button managebookbtn;
        private System.Windows.Forms.Button issuebooksbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label3;
    }
}