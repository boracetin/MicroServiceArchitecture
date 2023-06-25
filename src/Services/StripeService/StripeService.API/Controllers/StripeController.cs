using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using Stripe;
using Microsoft.Extensions.Options;
using StripeService.API.Models;
using System.Linq;

namespace StripeService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public StripeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("GetConfiguration")]
        public StripeConfigurationDto GetConfiguration()
        {
            return new StripeConfigurationDto
            {
                PublishableKey = _configuration["Stripe:PublishableKey"]
            };
        }

        [HttpPost]
        [Route("CreatePayment")]
        public async Task<ActionResult<string>> CreatePayment()
        {
            var options = new SessionCreateOptions
            {
                Mode = "payment", // One-time payment. Stripe supports recurring 'subscription' payments.
                LineItems = new List<SessionLineItemOptions>
                {
                    new()
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = 50, //burada kı bılgı payment servısı tammaladıgımda oradan gelecek dataya gore dolacaktır.
                            Currency = "USD",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "bora Deneme",
                                Images = new List<string> { "image Url bilgisi" }
                            },
                        },
                        Quantity = 1,
                    },
                },
                PaymentMethodTypes = new List<string> // Only card available in test mode?
                {
                    "card"
                },

                SuccessUrl = "http://localhost:3000/account/stripe-success", // uygulama ok olduktan sonrakı yonlenecegı sayfayı yaz bu olmadan calısmıyor deneme yapamadım 
                CancelUrl = "http://localhost:3000/account/stripe-cancel" // uygulama ok olduktan sonrakı yonlenecegı sayfayı yaz bu olmadan calısmıyor deneme yapamadım 


            };
            options.Mode = "payment";
            
            var service = new SessionService();

            var session = await service.CreateAsync(options);

            return session.Id;
        }

       
    }
}
