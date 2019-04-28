namespace SecretSanta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Emailsend = new System.Windows.Forms.Button();
            this.santatab2 = new System.Windows.Forms.TabPage();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SanteeBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CardBox = new System.Windows.Forms.TextBox();
            this.santatab.SuspendLayout();
            this.santatab1.SuspendLayout();
            this.santatab2.SuspendLayout();
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
            this.santatab.Location = new System.Drawing.Point(12, 12);
            this.santatab.Name = "santatab";
            this.santatab.SelectedIndex = 0;
            this.santatab.Size = new System.Drawing.Size(564, 400);
            this.santatab.TabIndex = 3;
            // 
            // santatab1
            // 
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
            this.Emailsend.Location = new System.Drawing.Point(440, 322);
            this.Emailsend.Name = "Emailsend";
            this.Emailsend.Size = new System.Drawing.Size(75, 23);
            this.Emailsend.TabIndex = 3;
            this.Emailsend.Text = "send email";
            this.Emailsend.UseVisualStyleBackColor = true;
            this.Emailsend.Click += new System.EventHandler(this.Emailsend_Click);
            // 
            // santatab2
            // 
            this.santatab2.Controls.Add(this.Namebox);
            this.santatab2.Location = new System.Drawing.Point(4, 22);
            this.santatab2.Name = "santatab2";
            this.santatab2.Padding = new System.Windows.Forms.Padding(3);
            this.santatab2.Size = new System.Drawing.Size(556, 374);
            this.santatab2.TabIndex = 1;
            this.santatab2.Text = "christmas";
            this.santatab2.UseVisualStyleBackColor = true;
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(14, 49);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(152, 20);
            this.Namebox.TabIndex = 0;
            this.Namebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price Limit";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gift Cards";
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
            // SanteeBox
            // 
            this.SanteeBox.Location = new System.Drawing.Point(387, 89);
            this.SanteeBox.Name = "SanteeBox";
            this.SanteeBox.Size = new System.Drawing.Size(149, 20);
            this.SanteeBox.TabIndex = 10;
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(387, 118);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(149, 20);
            this.LocationBox.TabIndex = 11;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Emailsname;
        private System.Windows.Forms.Button addemail;
        private System.Windows.Forms.TabControl santatab;
        private System.Windows.Forms.TabPage santatab1;
        private System.Windows.Forms.TabPage santatab2;
        private System.Windows.Forms.Button Emailsend;
        private System.Windows.Forms.TextBox Namebox;
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
    }
}

