namespace PaymentProcessor.Api.Models
{
    public record PaymentResponse
    {
        public bool Success { get; init; }
        public string Message { get; init; } = string.Empty;
        public string? TransactionId { get; init; }
    }
}
