using System.Linq;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;
using DeliveryServiceApi.Interfaces;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;


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

        [Test]
        public async Task SendOrder_FreeCourierAvailable_ShouldReturnNotFound()
        {
            // arrange
            WebApplicationFactory<Startup> webHost = new WebApplicationFactory<Startup>().WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    var orderService = services.SingleOrDefault(d => d.ServiceType == typeof(IOrderService));
                    services.Remove(orderService);
                    var mockService = new Mock<IOrderService>();

                    mockService.Setup(_ => _.IsFreeCourierAvailable()).Returns(() => false);
                    services.AddTransient(_ => mockService.Object);
                });
            });

            HttpClient httpClient = webHost.CreateClient();

            // actual

            HttpResponseMessage response = await httpClient.PostAsync("api/delivery/send-order", null);

            // assert

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
