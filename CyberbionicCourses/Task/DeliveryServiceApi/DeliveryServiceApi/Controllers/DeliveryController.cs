using Microsoft.AspNetCore.Mvc;
using DeliveryServiceApi.Interfaces;

namespace DeliveryServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : Controller
    {
        private readonly IOrderService _orderService;

        public DeliveryController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("check-status")]
        public IActionResult CheckStatus()
        {
            return Ok("Active");
        }

        [HttpPost("send-order")]
        public IActionResult SendOrder()
        {
            try
            {
                if (_orderService.IsFreeCourierAvailable())
                    return Ok("Order has been sent");
                return NotFound("Available courier not found");
            }
            catch
            {
                return BadRequest("Order rejected");
            }
        }
    }
}
