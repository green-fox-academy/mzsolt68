using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using RESTApiTest;

namespace RESTApiTest.Tester
{
    public class UnitTest1
    {
        private TestServer Server { get; set; }
        private HttpClient Client { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public async Task ShouldGetOK()
        {
            var response = await Client.GetAsync("/doubling");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        //[Theory]
        //[InlineData(3)]
        //public async Task ShouldGetSix(int input)
        //{
        //    var response = await client.GetAsync("/doubling?input=" + input);
        //    var result = JsonConvert.DeserializeObject("result");
        //    Assert.Equal(6, result);
        //}
    }
}
