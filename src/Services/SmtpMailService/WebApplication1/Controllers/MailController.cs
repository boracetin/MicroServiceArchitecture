using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmtpMailService.Api.Models;

namespace SmtpMailService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        //injecting the IMailService into the constructor
        public MailController(IMailService _MailService)
        {
            _mailService = _MailService;
        }

        [HttpPost]
        [Route("SendMail")]
        public  ActionResult<bool> SendMail(MailData mailData)
        {
            return Ok(_mailService.SendEmailAsync(mailData));
        }
    }
}
