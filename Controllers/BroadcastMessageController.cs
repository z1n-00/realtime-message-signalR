using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Api;

namespace BroadcastMessageController
{
    [ApiController]
    [Route("api/[controller]")]
    public class BroadcastMessageController : ControllerBase
    {
        private readonly IHubContext<ChatHub, IChatClient> _hubContext;

        public BroadcastMessageController(IHubContext<ChatHub, IChatClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> BroadcastMessage(string message)
        {
            await _hubContext.Clients.All.ReceivedMessage(message);
            return Ok(message);
        }
    }
}
