namespace StripeService.API.Models
{
    public class StripeCreatePaymentInput
    {
        public string SuccessUrl{ get; set; }

        public string CancelUrl { get; set; }

    }
}
