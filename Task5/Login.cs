using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using MailKit.Net.Pop3;


namespace Task5
{
    public partial class Login : Form
    {
        public static Login instance;
        public TextBox tb;
        public TextBox tb2;
        public Login()
        {
            InitializeComponent();
            instance = this;
            tb = txt_Email_login;
            tb2 = txt_password;
        }
       
        public void btn_Sign_in_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text.ToString().Trim();
            string email_login = txt_Email_login.Text.ToString().Trim();
            var Credential = new NetworkCredential(email_login, password);
            if (Credential != null)
            {
                EmailClient emailClient = new EmailClient();
                emailClient.Show();
            }      
            
        }
    }
}
