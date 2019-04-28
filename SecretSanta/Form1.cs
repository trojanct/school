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
            string line;
            List<SantaEmail> Santaemail = new List<SantaEmail>();
            SantaEmail Emails = new SantaEmail();

            System.IO.StreamReader Santafile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\secretsanta.txt");
            while ((line = Santafile.ReadLine()) != null)
            {
                Santaemail.Add(new SantaEmail()
                {
                    Secretemail = line,
                    Name = line,
                    Secretsantee = line
                });


            }
            MessageBox.Show(Santaemail[1].Name);

        }

        public void Main()
        {
            string line;
            List<SantaEmail> Santaemail = new List<SantaEmail>();
            SantaEmail Emails = new SantaEmail();

            System.IO.StreamReader Santafile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta");
            while ((line = Santafile.ReadLine()) != null)
            {
                Santaemail.Add(new SantaEmail()
                {
                    Secretemail = line,
                    Name = line,
                    Secretsantee = line
                });

              
            }
            MessageBox.Show("test");
        }

        private void Emails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class SantaEmail
        {
            public string Secretemail;
            public string Name;
            public string Secretsantee;
}
        public class SantaGift
        {
            private string name;
            private float Pricelimit;
            List<string> Wishlist = new List<string>();
            public string Giftcards;
            private string Santaemail;

     
        }
        public class Nonsantagift
        {
            List<string> Giftideas = new List<string>();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void details_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
