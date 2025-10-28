namespace PaymentProcessor.Api.Models
{
    public record PaymentRequest
    {
        public decimal Amount { get; init; }
        public string Currency { get; init; } = "USD";
        public string CardNumber { get; init; } = string.Empty;
        public string? Description { get; init; }
    }
}
