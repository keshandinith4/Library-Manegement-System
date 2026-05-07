namespace Library_Manegement_System
{
    partial class Reports
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isbnreportfeild = new System.Windows.Forms.TextBox();
            this.booknamereportfeild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailfeildreport = new System.Windows.Forms.TextBox();
            this.contactfeild = new System.Windows.Forms.TextBox();
            this.fullnamefeild = new System.Windows.Forms.TextBox();
            this.memberidfeild = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Report Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Book Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.isbnreportfeild);
            this.panel1.Controls.Add(this.booknamereportfeild);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 88);
            this.panel1.TabIndex = 12;
            // 
            // isbnreportfeild
            // 
            this.isbnreportfeild.Location = new System.Drawing.Point(104, 52);
            this.isbnreportfeild.Name = "isbnreportfeild";
            this.isbnreportfeild.Size = new System.Drawing.Size(162, 20);
            this.isbnreportfeild.TabIndex = 6;
            // 
            // booknamereportfeild
            // 
            this.booknamereportfeild.Location = new System.Drawing.Point(104, 16);
            this.booknamereportfeild.Name = "booknamereportfeild";
            this.booknamereportfeild.Size = new System.Drawing.Size(162, 20);
            this.booknamereportfeild.TabIndex = 4;
            this.booknamereportfeild.TextChanged += new System.EventHandler(this.booknamereportbtn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ISBN No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book\'s Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Member Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.emailfeildreport);
            this.panel2.Controls.Add(this.contactfeild);
            this.panel2.Controls.Add(this.fullnamefeild);
            this.panel2.Controls.Add(this.memberidfeild);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 162);
            this.panel2.TabIndex = 14;
            // 
            // emailfeildreport
            // 
            this.emailfeildreport.Location = new System.Drawing.Point(91, 121);
            this.emailfeildreport.Name = "emailfeildreport";
            this.emailfeildreport.Size = new System.Drawing.Size(175, 20);
            this.emailfeildreport.TabIndex = 7;
            // 
            // contactfeild
            // 
            this.contactfeild.Location = new System.Drawing.Point(91, 90);
            this.contactfeild.Name = "contactfeild";
            this.contactfeild.Size = new System.Drawing.Size(175, 20);
            this.contactfeild.TabIndex = 6;
            // 
            // fullnamefeild
            // 
            this.fullnamefeild.Location = new System.Drawing.Point(91, 58);
            this.fullnamefeild.Name = "fullnamefeild";
            this.fullnamefeild.Size = new System.Drawing.Size(175, 20);
            this.fullnamefeild.TabIndex = 5;
            // 
            // memberidfeild
            // 
            this.memberidfeild.Location = new System.Drawing.Point(91, 26);
            this.memberidfeild.Name = "memberidfeild";
            this.memberidfeild.Size = new System.Drawing.Size(175, 20);
            this.memberidfeild.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Contact No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Full Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Member ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(542, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "Developed By Keshan Jayaweera";
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.Location = new System.Drawing.Point(612, 378);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(71, 28);
            this.logoutbtn.TabIndex = 20;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(535, 378);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(71, 28);
            this.backbtn.TabIndex = 19;
            this.backbtn.Text = "< Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearbtn.Location = new System.Drawing.Point(231, 348);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(71, 28);
            this.clearbtn.TabIndex = 22;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 436);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox isbnreportfeild;
        private System.Windows.Forms.TextBox booknamereportfeild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailfeildreport;
        private System.Windows.Forms.TextBox contactfeild;
        private System.Windows.Forms.TextBox fullnamefeild;
        private System.Windows.Forms.TextBox memberidfeild;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}