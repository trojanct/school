﻿namespace SecretSanta
{
    partial class Santa
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
            this.Emailsname = new System.Windows.Forms.ComboBox();
            this.addemail = new System.Windows.Forms.Button();
            this.santatab = new System.Windows.Forms.TabControl();
            this.santatab1 = new System.Windows.Forms.TabPage();
            this.Secretb = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CardBox = new System.Windows.Forms.TextBox();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.SanteeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Emailsend = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.RichTextBox();
            this.santatab2 = new System.Windows.Forms.TabPage();
            this.schedulebutton = new System.Windows.Forms.Button();
            this.Folksbox = new System.Windows.Forms.TextBox();
            this.Attendancebox = new System.Windows.Forms.TextBox();
            this.Timebox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Placebox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kgiftnum = new System.Windows.Forms.TextBox();
            this.kgifts = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Fnum = new System.Windows.Forms.TextBox();
            this.Fgifts = new System.Windows.Forms.TextBox();
            this.kidsbox = new System.Windows.Forms.TextBox();
            this.Folkbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.santatab.SuspendLayout();
            this.santatab1.SuspendLayout();
            this.santatab2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Emailsname
            // 
            this.Emailsname.FormattingEnabled = true;
            this.Emailsname.Location = new System.Drawing.Point(24, 25);
            this.Emailsname.Name = "Emailsname";
            this.Emailsname.Size = new System.Drawing.Size(265, 21);
            this.Emailsname.TabIndex = 0;
            this.Emailsname.SelectedIndexChanged += new System.EventHandler(this.Emails_SelectedIndexChanged);
            // 
            // addemail
            // 
            this.addemail.Location = new System.Drawing.Point(461, 270);
            this.addemail.Name = "addemail";
            this.addemail.Size = new System.Drawing.Size(75, 23);
            this.addemail.TabIndex = 2;
            this.addemail.Text = "add Email";
            this.addemail.UseVisualStyleBackColor = true;
            this.addemail.Click += new System.EventHandler(this.addemail_Click);
            // 
            // santatab
            // 
            this.santatab.Controls.Add(this.santatab1);
            this.santatab.Controls.Add(this.santatab2);
            this.santatab.Controls.Add(this.tabPage1);
            this.santatab.Controls.Add(this.tabPage2);
            this.santatab.Location = new System.Drawing.Point(12, 12);
            this.santatab.Name = "santatab";
            this.santatab.SelectedIndex = 0;
            this.santatab.Size = new System.Drawing.Size(564, 400);
            this.santatab.TabIndex = 3;
            // 
            // santatab1
            // 
            this.santatab1.Controls.Add(this.Secretb);
            this.santatab1.Controls.Add(this.EmailBox);
            this.santatab1.Controls.Add(this.CardBox);
            this.santatab1.Controls.Add(this.FileBox);
            this.santatab1.Controls.Add(this.PriceBox);
            this.santatab1.Controls.Add(this.LocationBox);
            this.santatab1.Controls.Add(this.SanteeBox);
            this.santatab1.Controls.Add(this.label6);
            this.santatab1.Controls.Add(this.label5);
            this.santatab1.Controls.Add(this.label4);
            this.santatab1.Controls.Add(this.label3);
            this.santatab1.Controls.Add(this.label2);
            this.santatab1.Controls.Add(this.label1);
            this.santatab1.Controls.Add(this.Emailsend);
            this.santatab1.Controls.Add(this.details);
            this.santatab1.Controls.Add(this.addemail);
            this.santatab1.Controls.Add(this.Emailsname);
            this.santatab1.Location = new System.Drawing.Point(4, 22);
            this.santatab1.Name = "santatab1";
            this.santatab1.Padding = new System.Windows.Forms.Padding(3);
            this.santatab1.Size = new System.Drawing.Size(556, 374);
            this.santatab1.TabIndex = 0;
            this.santatab1.Text = "Santa";
            this.santatab1.UseVisualStyleBackColor = true;
            // 
            // Secretb
            // 
            this.Secretb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secretb.Location = new System.Drawing.Point(24, 299);
            this.Secretb.Name = "Secretb";
            this.Secretb.Size = new System.Drawing.Size(265, 53);
            this.Secretb.TabIndex = 16;
            this.Secretb.Text = "Secret Santa Button";
            this.Secretb.UseVisualStyleBackColor = true;
            this.Secretb.Click += new System.EventHandler(this.Secretb_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(387, 228);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(149, 20);
            this.EmailBox.TabIndex = 15;
            // 
            // CardBox
            // 
            this.CardBox.Location = new System.Drawing.Point(387, 199);
            this.CardBox.Name = "CardBox";
            this.CardBox.Size = new System.Drawing.Size(149, 20);
            this.CardBox.TabIndex = 14;
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(387, 173);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(149, 20);
            this.FileBox.TabIndex = 13;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(387, 144);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(149, 20);
            this.PriceBox.TabIndex = 12;
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(387, 118);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(149, 20);
            this.LocationBox.TabIndex = 11;
            // 
            // SanteeBox
            // 
            this.SanteeBox.Location = new System.Drawing.Point(387, 89);
            this.SanteeBox.Name = "SanteeBox";
            this.SanteeBox.Size = new System.Drawing.Size(149, 20);
            this.SanteeBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Santa Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gift Cards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "List File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // Emailsend
            // 
            this.Emailsend.Location = new System.Drawing.Point(461, 299);
            this.Emailsend.Name = "Emailsend";
            this.Emailsend.Size = new System.Drawing.Size(75, 23);
            this.Emailsend.TabIndex = 3;
            this.Emailsend.Text = "send email";
            this.Emailsend.UseVisualStyleBackColor = true;
            this.Emailsend.Click += new System.EventHandler(this.Emailsend_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(24, 81);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(265, 180);
            this.details.TabIndex = 1;
            this.details.Text = "";
            this.details.TextChanged += new System.EventHandler(this.details_TextChanged);
            // 
            // santatab2
            // 
            this.santatab2.Controls.Add(this.schedulebutton);
            this.santatab2.Controls.Add(this.Folksbox);
            this.santatab2.Controls.Add(this.Attendancebox);
            this.santatab2.Controls.Add(this.Timebox);
            this.santatab2.Controls.Add(this.label10);
            this.santatab2.Controls.Add(this.label9);
            this.santatab2.Controls.Add(this.label8);
            this.santatab2.Controls.Add(this.label7);
            this.santatab2.Controls.Add(this.Placebox);
            this.santatab2.Location = new System.Drawing.Point(4, 22);
            this.santatab2.Name = "santatab2";
            this.santatab2.Padding = new System.Windows.Forms.Padding(3);
            this.santatab2.Size = new System.Drawing.Size(556, 374);
            this.santatab2.TabIndex = 1;
            this.santatab2.Text = "christmas";
            this.santatab2.UseVisualStyleBackColor = true;
            // 
            // schedulebutton
            // 
            this.schedulebutton.Font = new System.Drawing.Font("Sitka Heading", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulebutton.Location = new System.Drawing.Point(20, 273);
            this.schedulebutton.Name = "schedulebutton";
            this.schedulebutton.Size = new System.Drawing.Size(180, 36);
            this.schedulebutton.TabIndex = 8;
            this.schedulebutton.Text = "Send Schedule";
            this.schedulebutton.UseVisualStyleBackColor = true;
            this.schedulebutton.Click += new System.EventHandler(this.schedulebutton_Click);
            // 
            // Folksbox
            // 
            this.Folksbox.Location = new System.Drawing.Point(20, 227);
            this.Folksbox.Name = "Folksbox";
            this.Folksbox.Size = new System.Drawing.Size(363, 20);
            this.Folksbox.TabIndex = 7;
            // 
            // Attendancebox
            // 
            this.Attendancebox.Location = new System.Drawing.Point(20, 174);
            this.Attendancebox.Name = "Attendancebox";
            this.Attendancebox.Size = new System.Drawing.Size(363, 20);
            this.Attendancebox.TabIndex = 6;
            // 
            // Timebox
            // 
            this.Timebox.Location = new System.Drawing.Point(20, 114);
            this.Timebox.Name = "Timebox";
            this.Timebox.Size = new System.Drawing.Size(363, 20);
            this.Timebox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Who is bringing the folks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Family Attending";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Location";
            // 
            // Placebox
            // 
            this.Placebox.Location = new System.Drawing.Point(20, 58);
            this.Placebox.Name = "Placebox";
            this.Placebox.Size = new System.Drawing.Size(363, 20);
            this.Placebox.TabIndex = 0;
            this.Placebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.kidsbox);
            this.tabPage1.Controls.Add(this.kgiftnum);
            this.tabPage1.Controls.Add(this.kgifts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 374);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kids";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kgiftnum
            // 
            this.kgiftnum.Location = new System.Drawing.Point(121, 176);
            this.kgiftnum.Name = "kgiftnum";
            this.kgiftnum.Size = new System.Drawing.Size(236, 20);
            this.kgiftnum.TabIndex = 2;
            // 
            // kgifts
            // 
            this.kgifts.Location = new System.Drawing.Point(121, 118);
            this.kgifts.Name = "kgifts";
            this.kgifts.Size = new System.Drawing.Size(236, 20);
            this.kgifts.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.Folkbox);
            this.tabPage2.Controls.Add(this.Fnum);
            this.tabPage2.Controls.Add(this.Fgifts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(556, 374);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Folks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Fnum
            // 
            this.Fnum.Location = new System.Drawing.Point(144, 189);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(236, 20);
            this.Fnum.TabIndex = 5;
            // 
            // Fgifts
            // 
            this.Fgifts.Location = new System.Drawing.Point(144, 136);
            this.Fgifts.Name = "Fgifts";
            this.Fgifts.Size = new System.Drawing.Size(236, 20);
            this.Fgifts.TabIndex = 4;
            // 
            // kidsbox
            // 
            this.kidsbox.Location = new System.Drawing.Point(121, 57);
            this.kidsbox.Name = "kidsbox";
            this.kidsbox.Size = new System.Drawing.Size(236, 20);
            this.kidsbox.TabIndex = 3;
            // 
            // Folkbox
            // 
            this.Folkbox.Location = new System.Drawing.Point(144, 84);
            this.Folkbox.Name = "Folkbox";
            this.Folkbox.Size = new System.Drawing.Size(236, 20);
            this.Folkbox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Kid Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Gifts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Number of Gifts";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(141, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Number of Gifts";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gifts";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Grandparents Name";
            // 
            // Santa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.santatab);
            this.Name = "Santa";
            this.Text = "Secret Santa";
            this.Load += new System.EventHandler(this.Santa_Load);
            this.santatab.ResumeLayout(false);
            this.santatab1.ResumeLayout(false);
            this.santatab1.PerformLayout();
            this.santatab2.ResumeLayout(false);
            this.santatab2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Emailsname;
        private System.Windows.Forms.Button addemail;
        private System.Windows.Forms.TabControl santatab;
        private System.Windows.Forms.TabPage santatab1;
        private System.Windows.Forms.TabPage santatab2;
        private System.Windows.Forms.Button Emailsend;
        private System.Windows.Forms.TextBox Placebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox CardBox;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.TextBox SanteeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Secretb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button schedulebutton;
        private System.Windows.Forms.TextBox Folksbox;
        private System.Windows.Forms.TextBox Attendancebox;
        private System.Windows.Forms.TextBox Timebox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox kgiftnum;
        private System.Windows.Forms.TextBox kgifts;
        private System.Windows.Forms.TextBox Fnum;
        private System.Windows.Forms.TextBox Fgifts;
        private System.Windows.Forms.TextBox kidsbox;
        private System.Windows.Forms.TextBox Folkbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

