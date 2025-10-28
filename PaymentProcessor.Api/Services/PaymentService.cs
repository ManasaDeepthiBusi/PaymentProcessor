using PaymentProcessor.Api.Models;

namespace PaymentProcessor.Api.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request)
        {
            // Very basic rule: amount must be > 0
            if (request.Amount <= 0)
            {
                return Task.FromResult(new PaymentResponse
                {
                    Success = false,
                    Message = "Invalid amount. Must be greater than zero.",
                    TransactionId = null
                });
            }

            // Simulate processing and return success
            var tx = Guid.NewGuid().ToString("N");

            return Task.FromResult(new PaymentResponse
            {
                Success = true,
                Message = "Payment processed successfully.",
                TransactionId = tx
            });
        }
    }
}
