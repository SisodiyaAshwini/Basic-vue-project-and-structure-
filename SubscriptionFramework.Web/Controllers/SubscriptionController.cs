using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SubscriptionFramework.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        // GET: api/Subscription
        [HttpGet]
        public IList<Subscription> GetSubscription()
        {
            var subscription = new Object();

            using (StreamReader r = new StreamReader("~/test.json"))
            {
                string json = r.ReadToEnd();
                var root = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Subscription>>(json);
                return root;
            }
        }         

        public class Subscription
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public Boolean Status { get; set; }
        }
    }
}
