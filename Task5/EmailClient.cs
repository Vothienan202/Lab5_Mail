using System;
using System.Windows.Forms;
using System.Net;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using MailKit.Net.Pop3;
namespace Task5
{
    public partial class EmailClient : Form
    {
        public class EmailAddress
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        public class EmailMessage
        {
            public EmailMessage()
            {
                ToAddresses = new List<EmailAddress>();
                FromAddresses = new List<EmailAddress>();
            }
            public List<EmailAddress> ToAddresses { get; set; }
            public List<EmailAddress> FromAddresses { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
        }

        public EmailClient instance;
        public EmailClient()
        {
            InitializeComponent();
            instance = this;
            using (var Client = new Pop3Client())
            {
                string email = Login.instance.tb.Text.ToString().Trim();
                string password = Login.instance.tb2.Text.ToString().Trim();

                Client.Connect("pop.gmail.com", 995, true);
                Client.AuthenticationMechanisms.Remove("XOAUTH2");
                Client.Authenticate(email, password);
       
                List<EmailMessage> emails = new List<EmailMessage>();
                list_mail.Columns.Add("Email", 200);
                list_mail.Columns.Add("From", 100);
                list_mail.Columns.Add("Thời gian", 100);
                list_mail.View = View.Details;
                for (int i = 0; i < Client.Count; i++)
                {
                    var message = Client.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    list_mail.Items.Add(name);
                }
            }
        }

        

        private void btn_Compose_Click(object sender, EventArgs e)
        {
            Compose compose = new Compose();
            compose.Show();
        }
    }
}
