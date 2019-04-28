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
            this.Emails = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.addemail = new System.Windows.Forms.Button();
            this.santatab = new System.Windows.Forms.TabControl();
            this.santatab1 = new System.Windows.Forms.TabPage();
            this.Emailsend = new System.Windows.Forms.Button();
            this.santatab2 = new System.Windows.Forms.TabPage();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.santatab.SuspendLayout();
            this.santatab1.SuspendLayout();
            this.santatab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Emails
            // 
            this.Emails.FormattingEnabled = true;
            this.Emails.Location = new System.Drawing.Point(24, 25);
            this.Emails.Name = "Emails";
            this.Emails.Size = new System.Drawing.Size(265, 21);
            this.Emails.TabIndex = 0;
            this.Emails.SelectedIndexChanged += new System.EventHandler(this.Emails_SelectedIndexChanged);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(24, 69);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(265, 180);
            this.details.TabIndex = 1;
            this.details.Text = "";
            this.details.TextChanged += new System.EventHandler(this.details_TextChanged);
            // 
            // addemail
            // 
            this.addemail.Location = new System.Drawing.Point(440, 267);
            this.addemail.Name = "addemail";
            this.addemail.Size = new System.Drawing.Size(75, 23);
            this.addemail.TabIndex = 2;
            this.addemail.Text = "add Email";
            this.addemail.UseVisualStyleBackColor = true;
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
            this.santatab1.Controls.Add(this.label2);
            this.santatab1.Controls.Add(this.label1);
            this.santatab1.Controls.Add(this.Emailsend);
            this.santatab1.Controls.Add(this.details);
            this.santatab1.Controls.Add(this.addemail);
            this.santatab1.Controls.Add(this.Emails);
            this.santatab1.Location = new System.Drawing.Point(4, 22);
            this.santatab1.Name = "santatab1";
            this.santatab1.Padding = new System.Windows.Forms.Padding(3);
            this.santatab1.Size = new System.Drawing.Size(556, 374);
            this.santatab1.TabIndex = 0;
            this.santatab1.Text = "Santa";
            this.santatab1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Santa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.santatab);
            this.Name = "Santa";
            this.Text = "Secret Santa";
            this.santatab.ResumeLayout(false);
            this.santatab1.ResumeLayout(false);
            this.santatab1.PerformLayout();
            this.santatab2.ResumeLayout(false);
            this.santatab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Emails;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.Button addemail;
        private System.Windows.Forms.TabControl santatab;
        private System.Windows.Forms.TabPage santatab1;
        private System.Windows.Forms.TabPage santatab2;
        private System.Windows.Forms.Button Emailsend;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

