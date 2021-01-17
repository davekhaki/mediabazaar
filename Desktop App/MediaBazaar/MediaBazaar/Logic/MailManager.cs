using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOO;

namespace MediaBazaar.Logic
{
    public static class MailManager
    {
        public static void SendMail(string body, string receiver, string subject)
        {
            var message = new MailMessage(Config.Mail, receiver);
            message.Subject = subject;
            message.Body = body;

            var smtp = new SmtpClient("smtp.gmail.com", 587);
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
