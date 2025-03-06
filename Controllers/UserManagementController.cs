using Microsoft.AspNetCore.Mvc;
using System;

namespace Quickchat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserManagementController : ControllerBase
    {
        [HttpPost("UserRegistration")]
        public IActionResult Echo([FromBody] object body)
        {
            Console.WriteLine("Received Body: " + System.Text.Json.JsonSerializer.Serialize(body)); // Console me print karega
            return Ok(body); // Jo body aayi, wahi return karega
        }
    }
}
