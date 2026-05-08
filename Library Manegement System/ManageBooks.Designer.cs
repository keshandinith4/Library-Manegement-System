namespace Library_Manegement_System
{
    partial class ManageBooks
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
            this.label9 = new System.Windows.Forms.Label();
            this.pricefeild = new System.Windows.Forms.TextBox();
            this.categoryfeild = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.updatebookbtn = new System.Windows.Forms.Button();
            this.deletebookbtn = new System.Windows.Forms.Button();
            this.addbookbtn = new System.Windows.Forms.Button();
            this.isbnfeild = new System.Windows.Forms.TextBox();
            this.authorfeild = new System.Windows.Forms.TextBox();
            this.titlefeild = new System.Windows.Forms.TextBox();
            this.bookidfeild = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Manage Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pricefeild);
            this.panel1.Controls.Add(this.categoryfeild);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.updatebookbtn);
            this.panel1.Controls.Add(this.deletebookbtn);
            this.panel1.Controls.Add(this.addbookbtn);
            this.panel1.Controls.Add(this.isbnfeild);
            this.panel1.Controls.Add(this.authorfeild);
            this.panel1.Controls.Add(this.titlefeild);
            this.panel1.Controls.Add(this.bookidfeild);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 293);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price";
            // 
            // pricefeild
            // 
            this.pricefeild.Location = new System.Drawing.Point(91, 181);
            this.pricefeild.Name = "pricefeild";
            this.pricefeild.Size = new System.Drawing.Size(175, 20);
            this.pricefeild.TabIndex = 14;
            // 
            // categoryfeild
            // 
            this.categoryfeild.Location = new System.Drawing.Point(91, 146);
            this.categoryfeild.Name = "categoryfeild";
            this.categoryfeild.Size = new System.Drawing.Size(175, 20);
            this.categoryfeild.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Category";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(218, 235);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(62, 41);
            this.clearbtn.TabIndex = 11;
            this.clearbtn.Text = "Clear ";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // updatebookbtn
            // 
            this.updatebookbtn.Location = new System.Drawing.Point(150, 235);
            this.updatebookbtn.Name = "updatebookbtn";
            this.updatebookbtn.Size = new System.Drawing.Size(62, 41);
            this.updatebookbtn.TabIndex = 10;
            this.updatebookbtn.Text = "Update Book";
            this.updatebookbtn.UseVisualStyleBackColor = true;
            this.updatebookbtn.Click += new System.EventHandler(this.updatebookbtn_Click);
            // 
            // deletebookbtn
            // 
            this.deletebookbtn.Location = new System.Drawing.Point(82, 235);
            this.deletebookbtn.Name = "deletebookbtn";
            this.deletebookbtn.Size = new System.Drawing.Size(62, 41);
            this.deletebookbtn.TabIndex = 9;
            this.deletebookbtn.Text = "Delete Book";
            this.deletebookbtn.UseVisualStyleBackColor = true;
            this.deletebookbtn.Click += new System.EventHandler(this.deletebookbtn_Click);
            // 
            // addbookbtn
            // 
            this.addbookbtn.Location = new System.Drawing.Point(14, 235);
            this.addbookbtn.Name = "addbookbtn";
            this.addbookbtn.Size = new System.Drawing.Size(62, 41);
            this.addbookbtn.TabIndex = 8;
            this.addbookbtn.Text = "+ Add Book";
            this.addbookbtn.UseVisualStyleBackColor = true;
            this.addbookbtn.Click += new System.EventHandler(this.addbookbtn_Click);
            // 
            // isbnfeild
            // 
            this.isbnfeild.Location = new System.Drawing.Point(91, 112);
            this.isbnfeild.Name = "isbnfeild";
            this.isbnfeild.Size = new System.Drawing.Size(175, 20);
            this.isbnfeild.TabIndex = 7;
            // 
            // authorfeild
            // 
            this.authorfeild.Location = new System.Drawing.Point(91, 81);
            this.authorfeild.Name = "authorfeild";
            this.authorfeild.Size = new System.Drawing.Size(175, 20);
            this.authorfeild.TabIndex = 6;
            // 
            // titlefeild
            // 
            this.titlefeild.Location = new System.Drawing.Point(91, 49);
            this.titlefeild.Name = "titlefeild";
            this.titlefeild.Size = new System.Drawing.Size(175, 20);
            this.titlefeild.TabIndex = 5;
            // 
            // bookidfeild
            // 
            this.bookidfeild.Location = new System.Drawing.Point(91, 17);
            this.bookidfeild.Name = "bookidfeild";
            this.bookidfeild.Size = new System.Drawing.Size(175, 20);
            this.bookidfeild.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Books Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Search Books";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(405, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 20);
            this.textBox5.TabIndex = 13;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(501, 321);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(71, 28);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "< Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.Location = new System.Drawing.Point(578, 321);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(71, 28);
            this.logoutbtn.TabIndex = 15;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(505, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "Developed By Keshan Jayaweera";
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 373);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageBooks";
            this.Text = "ManageBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button updatebookbtn;
        private System.Windows.Forms.Button deletebookbtn;
        private System.Windows.Forms.Button addbookbtn;
        private System.Windows.Forms.TextBox isbnfeild;
        private System.Windows.Forms.TextBox authorfeild;
        private System.Windows.Forms.TextBox titlefeild;
        private System.Windows.Forms.TextBox bookidfeild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pricefeild;
        private System.Windows.Forms.TextBox categoryfeild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label11;
    }
}