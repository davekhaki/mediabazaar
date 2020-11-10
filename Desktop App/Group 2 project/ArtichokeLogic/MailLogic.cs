using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;

namespace ArtichokeLogic
{
    public class MailLogic
    {
        //class for the logic behind sending an email with a new employee's login details

        public void SendLoginDetails(string username, string password, string receiver)
        {
            MailMessage message = new MailMessage(Config.Mail, receiver);
            message.Subject = "Login Credentials";
            message.Body = $"Welcome to Media Bazaar! \nHere are you Login Credentials for all our services: Username-{username} Password-{password}";


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential()
            {
                UserName = Config.Mail,
                Password = Config.MailPassword
            };
            smtp.EnableSsl = true;
            smtp.Send(message);

        }

        //change password email ? with code to validate *
        public void SendNewPasswordConfirm(string receiver)
        {
            MailMessage message = new MailMessage(Config.Mail, receiver);
            message.Subject = "Password Change";
            message.Body = $"Your password has been changed, if this was not you, please contact a system administrator.";


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential()
            {
                UserName = Config.Mail,
                Password = Config.MailPassword
            };
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
