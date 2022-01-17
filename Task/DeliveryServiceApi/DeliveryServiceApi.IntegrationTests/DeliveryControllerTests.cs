using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;


namespace DeliveryServiceApi.IntegrationTests
{
    [TestFixture]
    public class DeliveryControllerTests
    {
        [Test]
        public async Task CheckStatus_SendRequest_ShouldReturnOk()
        {
            // arrange
            WebApplicationFactory<Startup> webHost = new WebApplicationFactory<Startup>().WithWebHostBuilder(_ => { });
            HttpClient httpClient = webHost.CreateClient();

            // actual

            HttpResponseMessage response = await httpClient.GetAsync("api/delivery/check-status");

            // assert

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
