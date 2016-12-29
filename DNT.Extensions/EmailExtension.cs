using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace DNT.Extensions
{
    public static class EmailExtension
    {
        public static string SendMailMessage(MailMessage message, string smtpServer, int smtpServerPort, string smtpUserName, string smtpPassword, bool enableSSL)
        {
            StringBuilder errorMessage = new StringBuilder();
            if (message == null)
                throw new ArgumentNullException("message");
            try
            {
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;
                var smtp = new SmtpClient(smtpServer);
                smtp.Credentials = new NetworkCredential(smtpUserName, smtpPassword);
                smtp.Port = smtpServerPort;
                smtp.EnableSsl = enableSSL;
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                errorMessage.Append("Error sending email in SendMailSending");
                Exception current = ex;
                while (current != null)
                {
                    if (errorMessage.Length > 0) errorMessage.Append(" ");
                    errorMessage.Append(current.Message);
                    current = current.InnerException;
                }
            }
            return errorMessage.ToString();
        }
    }
}
