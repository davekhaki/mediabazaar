using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Media_Bazaar_Logic.MailLogic
{
    public class MailSender
    {
        public void SendEmail(string cc, string subject, string body)
        {
            var message = new MailMessage(Config.MailAddress, cc) {Subject = subject, Body = body};

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential()
                {
                    UserName = Config.MailAddress, Password = Config.MailPassword
                },
                EnableSsl = true
            };
            smtp.Send(message);
        }
    }
}
