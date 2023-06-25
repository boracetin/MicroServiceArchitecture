using MailKit.Security;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using SmtpMailService.Api.Models;

namespace SmtpMailService.Api.Service
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _config;

        public MailService(IConfiguration config)
        {
            _config = config;
        }


        public async Task SendEmailAsync(MailData request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
            email.To.Add(MailboxAddress.Parse(request.EmailToId));
            email.Subject = request.EmailSubject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.EmailBody };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }

}
