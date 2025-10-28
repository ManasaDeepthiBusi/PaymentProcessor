# PaymentProcessor (example)

A minimal .NET 8 Web API and xUnit tests demonstrating a basic payment processor.

nStructure:
- PaymentProcessor.Api/ - Web API project
- PaymentProcessor.Tests/ - xUnit tests for the payment service

Quick commands (PowerShell on Windows):

```powershell
# Build API
dotnet build "C:\Users\mdeep\source\PaymentProcessor\PaymentProcessor.Api\PaymentProcessor.Api.csproj"

# Run tests
dotnet test "C:\Users\mdeep\source\PaymentProcessor\PaymentProcessor.Tests\PaymentProcessor.Tests.csproj"

# Run the API
dotnet run --project "C:\Users\mdeep\source\PaymentProcessor\PaymentProcessor.Api\PaymentProcessor.Api.csproj"
```

Behavior:
- IPaymentService.ProcessPaymentAsync: returns success when Amount > 0, otherwise failure.

Notes:
- This is intentionally simple. In a real system you'd add validation, logging, persistence, and secure card handling.
