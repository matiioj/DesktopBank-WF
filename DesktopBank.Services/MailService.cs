using DesktopBank.DAL;
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


        //Se traen los datos del archivo app.config
        public MailService()
        {
            var Section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            if (Section != null)
            {
                settingsMail = new MailSettings(
                Section["Server"], int.Parse(Section["Port"]), Section["FromName"],
                Section["FromEmail"], Section["UserName"], Section["Password"]);
            }
            else
            {
                settingsMail = new MailSettings("smtp.gmail.com", 587, "ISTIC DesktopBank", "isticwallet@gmail.com", "isticwallet@gmail.com", "xszp gygt ihqw pcre");
            }

        }

        public void SendMail(MailData dataMail)
        {

            //Cuerpo del mail
            var mail = new MailMessage();
            mail.To.Add(dataMail.MailTo);
            mail.Subject = dataMail.Subject;
            mail.From = new MailAddress(settingsMail.FromEmail, settingsMail.FromName);
            mail.IsBodyHtml = true;
            mail.Body = dataMail.Body;

            //Conexión con el cliente
            var client = new SmtpClient();
            client.Host = settingsMail.Server;
            client.Port = settingsMail.Port;
            client.Credentials = new NetworkCredential(settingsMail.UserName,
                settingsMail.Password);
            client.EnableSsl = true;

            //Se envía el correo
            client.Send(mail);
            client.Dispose();

        }
    }
}
