using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.IO;
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


            //string line;
            //List<SantaEmail> Santaemail = new List<SantaEmail>();
            //SantaEmail Emails = new SantaEmail();

            //System.IO.StreamReader Santafile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\secretsanta.txt");
            //while ((line = Santafile.ReadLine()) != null)
            //{
            //    Santaemail.Add(new SantaEmail()
            //    {
            //        Secretemail = line,
            //        Name = line,
            //        Secretsantee = line
            //    });


            //}
            //MessageBox.Show(Santaemail[1].Name);

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
            string name = Emailsname.Text;
            List<SantaGift> Wishname = new List<SantaGift>();
            Finddata(Wishname, name);

        }

        public class SantaEmail
        {
            public int number { get; set; }
            public string Secretemail { get; set; }
            public string Name { get; set; }
            public string Secretsantee{get; set; }
        }
        public class SantaGift
        {
            public string name { get; set; }
            public string location { get; set; }
            public string Pricelimit { get; set; }
            public string Listfile { get; set; }
            public string Giftcards { get; set; }
            public string Santaemail { get; set; }


        }
        public class Christmaslocation
        {
            public string Location { get; set; }
            public string Time { get; set; }
            public string Familyattendance { get; set; }
            public string GrandmaAttender { get; set; }

        }
        public class Giftandprice
        {
            public string gift;
            public string price;
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
        void Finddata(List<SantaGift>Wishname, string name)
        {
            string line;
            int linenumber = 0;
            string address = "C:\\Users\\BlooddSkullKing\\source\\repos\\school\\SecretSanta\\wishlists\\";
            details.Clear();

            System.IO.StreamReader Wishfile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\wishlist.txt");
            while ((line = Wishfile.ReadLine()) != null)
            {
                Wishname.Add(new SantaGift()
                {
                    name = line,
                    location = Wishfile.ReadLine(),
                    Pricelimit = Wishfile.ReadLine(),
                    Listfile = Wishfile.ReadLine(),
                    Giftcards = Wishfile.ReadLine(),
                    Santaemail = Wishfile.ReadLine()
                });

            }
            
            for (int d = 0; d < Wishname.Count; d++)
            {
                if (Wishname[d].name == name)
                {
                    address = address + Wishname[d].Listfile;
                    Fillinfo(Wishname, d);
                    System.IO.StreamReader listfile = new System.IO.StreamReader(address);

           
                    while ((line = listfile.ReadLine()) != null)
                    {
                        if (linenumber == 0)
                        {
                            details.Text = line;
                            linenumber = 1;
                        }
                        else
                        {
                            details.AppendText(Environment.NewLine + line);
                        }
                    }
                    listfile.Close();
                }
            }
            Wishfile.Close();
        }
        void Fillinfo(List<SantaGift> info, int temp)
        {
            SanteeBox.Text = info[temp].name;
            LocationBox.Text = info[temp].location;
            PriceBox.Text = info[temp].Pricelimit;
            FileBox.Text = info[temp].Listfile;
            CardBox.Text = info[temp].Giftcards;
            EmailBox.Text = info[temp].Santaemail;

        }
        void Fillselection(List<SantaGift>Names)
        {

            int limit = Names.Count;
            for( int n = 0; n < limit; n++)
            {
                Emailsname.Items.Add(Names[n].name);
            }
        }
        void Updatesecretsantalist(List<SantaGift> names)
        {
            List<SantaEmail> Secretlist = new List<SantaEmail>();
            Random Santeenum = new Random();
            int[] randomcheck = new int[names.Count];
            int number = 0;

           
            for (int s = 0; s < names.Count; s++)
            {
                Secretlist.Add(new SantaEmail()
                {

                    Name = names[s].name,
                    Secretemail = names[s].Santaemail,
                    number = s


                });
                    
                 
            
               
                
            }
            
            for (int q = 0; q < Secretlist.Count; q++)
            {
                number = Santeenum.Next(Secretlist.Count);
                while (Secretlist[q].number == number || randomcheck[number] == 1 )
                {
                    number = Santeenum.Next(Secretlist.Count);
                }
                randomcheck[number] = 1;
                Secretlist[q].Secretsantee = Secretlist[number].Name;
            }

            printlist(Secretlist);
            Emaillist(Secretlist);

        }
        void printlist(List<SantaEmail> Plist)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\secretlist.txt")) 
            {
                
                foreach (SantaEmail person in Plist )
                {
                    file.WriteLine(person.Name);
                    file.WriteLine(person.number);
                    file.WriteLine(person.Secretemail);
                    file.WriteLine(person.Secretsantee);
                }
            }

        }
        void Emaillist(List<SantaEmail> Elist)
        {
            for (int e = 0; e < Elist.Count; e++)
            {
                MailMessage mail = new MailMessage("secretsantabos@gmail.com", Elist[e].Secretemail, "Secret Santa Gift Receiver", Elist[e].Secretsantee);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("secretsantabos@gmail.com", "secretsanta123");
                client.EnableSsl = true;
                client.Send(mail);
            }
        }
        void Filewishopen(string address, List<SantaGift>Santee,int temp)
        {
            string Wishlistaddress = address + Santee[temp].Listfile;

        }

        private void Santa_Load(object sender, EventArgs e)
        {


            string line;
            List<SantaEmail> Santaemail = new List<SantaEmail>();
            List<SantaGift> Wishlist = new List<SantaGift>();

            string address = "C:\\Users\\BlooddSkullKing\\source\\repos\\school\\SecretSanta\\wishlists\\";
            string matt = address;
            SantaEmail Emails = new SantaEmail();

            System.IO.StreamReader Santafile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\secretsanta.txt");
            while ((line = Santafile.ReadLine()) != null)
            {
                Santaemail.Add(new SantaEmail()
                {
                    Secretemail = line,
                    Name = Santafile.ReadLine(),
                    Secretsantee = Santafile.ReadLine()
                });

            }

            System.IO.StreamReader Wishfile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\wishlist.txt");
            while ((line = Wishfile.ReadLine()) != null)
            {
                Wishlist.Add(new SantaGift()
                {
                    name = line,
                    location = Wishfile.ReadLine(),
                    Pricelimit = Wishfile.ReadLine(),
                    Listfile = Wishfile.ReadLine(),
                    Giftcards = Wishfile.ReadLine(),
                    Santaemail = Wishfile.ReadLine()
                });

            }
           
            
            Wishfile.Close();
            
            
            //int limit = Santaemail.Count;
            //MessageBox.Show(Santaemail[0].Secretsantee, Santaemail[2].Secretsantee);
            //MessageBox.Show(limit.ToString());
            Fillselection(Wishlist);
        }

        private void addemail_Click(object sender, EventArgs e)
        {
            
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\santapartic.txt"))
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\wishlist.txt"))
            {
                w.WriteLine(SanteeBox.Text);
                w.WriteLine(LocationBox.Text);
                w.WriteLine(PriceBox.Text);
                w.WriteLine(FileBox.Text);
                w.WriteLine(CardBox.Text);
                w.WriteLine(EmailBox.Text);
            }
        }

        private void Secretb_Click(object sender, EventArgs e)
        {
            List<SantaGift> Wishlist = new List<SantaGift>();
            string line;
            System.IO.StreamReader Wishfile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\wishlist.txt");
            while ((line = Wishfile.ReadLine()) != null)
            {
           
                Wishlist.Add(new SantaGift()
                {
                    name = line,
                    location = Wishfile.ReadLine(),
                    Pricelimit = Wishfile.ReadLine(),
                    Listfile = Wishfile.ReadLine(),
                    Giftcards = Wishfile.ReadLine(),
                    Santaemail = Wishfile.ReadLine()
                });

            }
            Wishfile.Close();
            Updatesecretsantalist(Wishlist);
            
        }

        private void schedulebutton_Click(object sender, EventArgs e)
        {
            Christmaslocation Clocation = new Christmaslocation()
            {
                Location = Placebox.Text,
                Time = Timebox.Text,
                Familyattendance = Attendancebox.Text,
                GrandmaAttender = Folksbox.Text

            };
            printschedule(Clocation);
            

         
        }
        private void printschedule( Christmaslocation schedulelist)
        {
            string line;
            List<SantaGift> Slist = new List<SantaGift>();
           
            System.IO.StreamReader Wishfile = new System.IO.StreamReader(@"C:\Users\BlooddSkullKing\source\repos\school\SecretSanta\wishlist.txt");
            while ((line = Wishfile.ReadLine()) != null)
            {

                Slist.Add(new SantaGift()
                {
                    name = line,
                    location = Wishfile.ReadLine(),
                    Pricelimit = Wishfile.ReadLine(),
                    Listfile = Wishfile.ReadLine(),
                    Giftcards = Wishfile.ReadLine(),
                    Santaemail = Wishfile.ReadLine()
                });

            }
            Wishfile.Close();

            

            for (int e = 0; e < Slist.Count; e++)
            {
                MailMessage mail = new MailMessage("secretsantabos@gmail.com", Slist[e].Santaemail, "Christmas Schedule","The location is at" + schedulelist.Location + "\n" +schedulelist.Time + "\n" + schedulelist.Familyattendance + "\n" + schedulelist.GrandmaAttender);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("secretsantabos@gmail.com", "secretsanta123");
                client.EnableSsl = true;
                client.Send(mail);
            }
        }
    }
}
