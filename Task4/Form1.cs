using System;
using System.Windows.Forms;
using System.Net;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using MailKit.Net.Pop3;

namespace Task4
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

            void btn_Login_Click(object sender, EventArgs e)
            {

                using (var Client = new Pop3Client())
                {
                    
                    string email = txt_mail.Text.ToString().Trim();
                    string password = txt_password.Text.ToString().Trim();
                    var basicCredential = new NetworkCredential(email, password);
                    Client.Connect("pop.gmail.com", 995, true); 
                    Client.AuthenticationMechanisms.Remove("XOAUTH2");
                    Client.Authenticate(email, password);
                    List<EmailMessage> emails = new List<EmailMessage>();
                    listView1.Columns.Add("Email", 200);
                    listView1.Columns.Add("From", 100);
                    listView1.Columns.Add("Thời gian", 100);
                    listView1.View = View.Details;
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
                        listView1.Items.Add(name);
                    }
       
                }
            }
       
    }
}
