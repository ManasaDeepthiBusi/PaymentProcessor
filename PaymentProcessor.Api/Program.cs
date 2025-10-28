using PaymentProcessor.Api.Models;
using PaymentProcessor.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddScoped<IPaymentService, PaymentService>();

var app = builder.Build();

app.MapControllers();

app.Run();
