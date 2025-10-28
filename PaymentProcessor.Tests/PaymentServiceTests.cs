using PaymentProcessor.Api.Models;
using PaymentProcessor.Api.Services;
using System.Threading.Tasks;
using Xunit;

namespace PaymentProcessor.Tests
{
    public class PaymentServiceTests
    {
        [Fact]
        public async Task ProcessPayment_Succeeds_WhenAmountPositive()
        {
            var svc = new PaymentService();
            var req = new PaymentRequest { Amount = 10.50m, Currency = "USD", CardNumber = "4111111111111111" };

            var res = await svc.ProcessPaymentAsync(req);

            Assert.True(res.Success);
            Assert.NotNull(res.TransactionId);
            Assert.Equal("Payment processed successfully.", res.Message);
        }

        [Fact]
        public async Task ProcessPayment_Fails_WhenAmountZeroOrNegative()
        {
            var svc = new PaymentService();
            var req = new PaymentRequest { Amount = 0m, Currency = "USD", CardNumber = "4111111111111111" };

            var res = await svc.ProcessPaymentAsync(req);

            Assert.False(res.Success);
            Assert.Null(res.TransactionId);
            Assert.Contains("Invalid amount", res.Message);
        }
    }
}
