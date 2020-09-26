using ShellHacksBackend.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShellHacksBackend.Controllers
{
    public class TestController : ApiController
    {
        TestGateway tg = new TestGateway();

        [HttpGet]
        [Route("api/GetTest")]
        public string Test()
        {
            return tg.GetTest();
        }
        [HttpGet]
        [Route("api/GetTestID/{id}")]
        public int Test(int id)
        {
            return tg.GetTestID(id);
        }

    }
}
