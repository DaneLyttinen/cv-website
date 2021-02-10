using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorRealTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {

        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationsController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TopRequest title)
        {
            await _hubContext.Clients.All.SendAsync("notification", title);
            return Ok("Notification sent");
        }
        public class TopRequest
        {
            public int id { get; set; }
            public int loop { get; set; }
            public int score { get; set; }
            public string genome { get; set; }
            public override string ToString()
            {
                return $"{{{id}, {loop}, {score}, {genome}}}";
            }
        }
    }
}
