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

        //[HttpPost]
        //[EnableCors("CorsPolicy")]
        //public async Task<IActionResult> Post([FromQuery] TargetRequest treq)
        //{
        //    var client = new HttpClient();

        //    client.BaseAddress = new Uri("http://localhost:8091/");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
        //    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
        //    //client.DefaultRequestHeaders.Accept.Add("Access-Control-Allow-Origin", "*");
        //    //WriteLine($"[{tid()}] ... POST /target send {t}");
        //    var hrm = await client.PostAsJsonAsync("/target", treq);
        //    hrm.EnsureSuccessStatusCode();
        //    return Ok("Target Sent");
        //}
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
