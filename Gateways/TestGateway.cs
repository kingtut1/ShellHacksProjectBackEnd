using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShellHacksBackend.Gateways
{
    public class TestGateway
    {
        public string GetTest()
        {
            return "TestAPI";
        }
        public int GetTestID(int id)
        {
            return id;
        }
    }
}