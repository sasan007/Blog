using BlogManagement.Endpoints.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BlogManagement.Test
{
    public class PostControllerTest: IClassFixture<WebApplicationFactory<Startup>>
    {

        WebApplicationFactory<Startup> _fixture;

        public PostControllerTest(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Get_Post_By_Id_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Post/1");
            responseMessage.EnsureSuccessStatusCode();
            var content = await responseMessage.Content.ReadAsStringAsync();
            Assert.NotEqual("", content);
        }

        [Fact]
        public async Task Get_Posts_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Post");
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }
    }
}
