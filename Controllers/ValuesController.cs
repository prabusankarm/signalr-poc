using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CSPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHubContext<DataHub> _hub;

        public ValuesController(IHubContext<DataHub> hub)
        {
            _hub = hub;
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]object value)
        {
            await _hub.Clients.All.SendAsync("Add", value);
        }
       



    }
}
