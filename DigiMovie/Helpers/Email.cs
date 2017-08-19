using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace DigiMovie.Helpers
{
    public enum EmailType { Mailer, Info }
    public static class Email
    {
        public static MailAddress GetMailAddress(EmailType Type)
        {
            if (Type == EmailType.Mailer)
                return new MailAddress("pegahtorabi72@gmail.com");
            else
                return new MailAddress("pegitorabi.pt12@gmail.com");
        }
        public static string GetMailName(EmailType Type)
        {
            if (Type == EmailType.Mailer)
                return "pegahtorabi72@gmail.com";
            else
                return "pegitorabi.pt12@gmail.com";
        }
        public static SmtpClient GetSmtp(EmailType Type)
        {
            if (Type == EmailType.Info)
                return new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential { UserName = "pegahtorabi72@gmail.com", Password = "pegi132783" }
                };
            else
                return new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential { UserName = "pegitorabi.pt12@gmail.com", Password = "pegi132783" }
                };
        }
    }
}