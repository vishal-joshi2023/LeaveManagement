using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Serivices
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer; 
        private int smtpPort;
        private string fromEmailAddress;

        public EmailSender(string v1, int v2, string v3)
        {
            this.smtpServer = v1;
            this.smtpPort = v2;
            this.fromEmailAddress = v3;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage{
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

         // this adds all recipents ie To/cc/bcc  
        message.To.Add(new MailAddress(email));

         // client
        using var client = new SmtpClient(smtpServer, smtpPort);
        client.Send(message);

        return Task.CompletedTask;

        }
    }
}
