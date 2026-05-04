namespace Library_Manegement_System
{
    partial class Members
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.memberfeild = new System.Windows.Forms.TextBox();
            this.fullnamefeild = new System.Windows.Forms.TextBox();
            this.contactfeild = new System.Windows.Forms.TextBox();
            this.emailfeild = new System.Windows.Forms.TextBox();
            this.addmemberbtn = new System.Windows.Forms.Button();
            this.deletememberbtn = new System.Windows.Forms.Button();
            this.updatememberbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage Members";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.updatememberbtn);
            this.panel1.Controls.Add(this.deletememberbtn);
            this.panel1.Controls.Add(this.addmemberbtn);
            this.panel1.Controls.Add(this.emailfeild);
            this.panel1.Controls.Add(this.contactfeild);
            this.panel1.Controls.Add(this.fullnamefeild);
            this.panel1.Controls.Add(this.memberfeild);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 251);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Member Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Full Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contact No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // memberfeild
            // 
            this.memberfeild.Location = new System.Drawing.Point(91, 40);
            this.memberfeild.Name = "memberfeild";
            this.memberfeild.Size = new System.Drawing.Size(175, 20);
            this.memberfeild.TabIndex = 4;
            // 
            // fullnamefeild
            // 
            this.fullnamefeild.Location = new System.Drawing.Point(91, 72);
            this.fullnamefeild.Name = "fullnamefeild";
            this.fullnamefeild.Size = new System.Drawing.Size(175, 20);
            this.fullnamefeild.TabIndex = 5;
            // 
            // contactfeild
            // 
            this.contactfeild.Location = new System.Drawing.Point(91, 104);
            this.contactfeild.Name = "contactfeild";
            this.contactfeild.Size = new System.Drawing.Size(175, 20);
            this.contactfeild.TabIndex = 6;
            // 
            // emailfeild
            // 
            this.emailfeild.Location = new System.Drawing.Point(91, 135);
            this.emailfeild.Name = "emailfeild";
            this.emailfeild.Size = new System.Drawing.Size(175, 20);
            this.emailfeild.TabIndex = 7;
            // 
            // addmemberbtn
            // 
            this.addmemberbtn.Location = new System.Drawing.Point(14, 175);
            this.addmemberbtn.Name = "addmemberbtn";
            this.addmemberbtn.Size = new System.Drawing.Size(62, 41);
            this.addmemberbtn.TabIndex = 8;
            this.addmemberbtn.Text = "+ Add Member";
            this.addmemberbtn.UseVisualStyleBackColor = true;
            // 
            // deletememberbtn
            // 
            this.deletememberbtn.Location = new System.Drawing.Point(82, 175);
            this.deletememberbtn.Name = "deletememberbtn";
            this.deletememberbtn.Size = new System.Drawing.Size(62, 41);
            this.deletememberbtn.TabIndex = 9;
            this.deletememberbtn.Text = "Delete Member";
            this.deletememberbtn.UseVisualStyleBackColor = true;
            // 
            // updatememberbtn
            // 
            this.updatememberbtn.Location = new System.Drawing.Point(150, 175);
            this.updatememberbtn.Name = "updatememberbtn";
            this.updatememberbtn.Size = new System.Drawing.Size(62, 41);
            this.updatememberbtn.TabIndex = 10;
            this.updatememberbtn.Text = "Update Member";
            this.updatememberbtn.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(218, 175);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(62, 41);
            this.clearbtn.TabIndex = 11;
            this.clearbtn.Text = "Clear ";
            this.clearbtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Search Member ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(418, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 20);
            this.textBox5.TabIndex = 12;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(472, 305);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(71, 28);
            this.backbtn.TabIndex = 13;
            this.backbtn.Text = "< Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.Location = new System.Drawing.Point(549, 305);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(71, 28);
            this.logoutbtn.TabIndex = 14;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Developed By Keshan Jayaweera";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 354);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Members";
            this.Text = "Members";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addmemberbtn;
        private System.Windows.Forms.TextBox emailfeild;
        private System.Windows.Forms.TextBox contactfeild;
        private System.Windows.Forms.TextBox fullnamefeild;
        private System.Windows.Forms.TextBox memberfeild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button updatememberbtn;
        private System.Windows.Forms.Button deletememberbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label9;
    }
}