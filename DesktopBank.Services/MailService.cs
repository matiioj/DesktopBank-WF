using DesktopBank.BusinessObjects.Models;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace DesktopBank.Services
{
    public class MailService
    {
        MailSettings settingsMail;

        public MailService()
        {
            var Section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            settingsMail = new MailSettings(
                Section["Server"], int.Parse(Section["Port"]), Section["FromName"],
                Section["FromEmail"], Section["UserName"], Section["Password"]
                );
        }

        public void SendMail(MailData dataMail)
        {
            var mail = new MailMessage();
            mail.To.Add(dataMail.MailTo);
            mail.Subject = dataMail.Subject;
            mail.From = new MailAddress(settingsMail.FromEmail, settingsMail.FromName);
            mail.IsBodyHtml = true;
            mail.Body = dataMail.Body;

            var client = new SmtpClient();
            client.Host = settingsMail.Server;
            client.Port = settingsMail.Port;
            client.Credentials = new NetworkCredential(settingsMail.UserName,
                settingsMail.Password);
            client.EnableSsl = true;

            client.Send(mail);
            client.Dispose();

        }
    }
}
