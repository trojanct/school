using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Web;
using System.Net.Mail;
using System.Windows.Forms;

namespace SecretSanta
{
    public partial class Santa : Form
    {
        public Santa()
        {
            InitializeComponent();
        }

        private void Emails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class SantaEmail
        {

        }
        public class SantaGift
        {

        }
        public class BBGift
        {

        }

        private void Emailsend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("secretsantabos@gmail.com", "Cody.Ortega@trojans.dsu.edu", "coolstuff", "hello");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("secretsantabos@gmail.com", "secretsanta123");
            client.EnableSsl = true;
            client.Send(mail);

        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
