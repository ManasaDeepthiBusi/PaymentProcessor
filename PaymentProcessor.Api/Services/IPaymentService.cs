using PaymentProcessor.Api.Models;

namespace PaymentProcessor.Api.Services
{
    public interface IPaymentService
    {
        Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request);
    }
}
