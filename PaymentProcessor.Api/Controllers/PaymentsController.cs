using Microsoft.AspNetCore.Mvc;
using PaymentProcessor.Api.Models;
using PaymentProcessor.Api.Services;

namespace PaymentProcessor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<ActionResult<PaymentResponse>> Post([FromBody] PaymentRequest request)
        {
            if (request == null)
                return BadRequest("Invalid request");

            var result = await _paymentService.ProcessPaymentAsync(request);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
