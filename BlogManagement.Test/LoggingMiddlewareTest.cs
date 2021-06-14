using BlogManagement.Endpoints.API.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogManagement.Test
{
    [TestClass]
    public class LoggingMiddlewareTest
    {
        
        [TestMethod]
        public async Task LoggingMiddlewareTestee()
        {
            var hostBuilder = new HostBuilder()
                .ConfigureWebHost(webHost =>
                {
                    webHost.Configure(app =>
                    {
                        app.UseMiddleware<LoggingMiddleware>();
                    });
                });
            IHost host = await hostBuilder.StartAsync();
            HttpClient client = host.GetTestClient();

            var responseMessage = await client.GetAsync("/blog");
            responseMessage.EnsureSuccessStatusCode();
            var content = await responseMessage.Content.ReadAsStringAsync();
            Assert.Equals("", content);
        }
    }
}
