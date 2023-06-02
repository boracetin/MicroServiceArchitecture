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

        private static string s_wasmClientURL = string.Empty;

        public StripeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreatePayment(StripeCreatePaymentInput input)
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

                SuccessUrl = "" // uygulama ok olduktan sonrakı yonlenecegı sayfayı yaz bu olmadan calısmıyor deneme yapamadım 

            };
            options.Mode = "payment";
            
            var service = new SessionService();

            var session = await service.CreateAsync(options);

            return session.Id;
        }

       
    }
}
