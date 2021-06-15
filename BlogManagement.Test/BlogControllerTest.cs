using BlogManagement.Endpoints.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BlogManagement.Test
{
    public class BlogControllerTest: IClassFixture<WebApplicationFactory<Startup>>
    {

        WebApplicationFactory<Startup> _fixture;

        public BlogControllerTest(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Get_Blog_By_Id_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Blog/1");
            responseMessage.EnsureSuccessStatusCode();
            var content = await responseMessage.Content.ReadAsStringAsync();
            Assert.NotEqual("", content);
        }

        [Fact]
        public async Task Get_Blogs_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Blog");
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }
    }
}
