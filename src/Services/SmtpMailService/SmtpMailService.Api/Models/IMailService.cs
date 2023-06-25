namespace SmtpMailService.Api.Models
{
    public interface IMailService
    {
        Task SendEmailAsync(MailData message);
    }
}
