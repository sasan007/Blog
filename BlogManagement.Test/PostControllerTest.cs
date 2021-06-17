using PostManagement.Endpoints.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using BlogManagement.Endpoints.API;
using BlogManagement.Core.ApplicationServices.Command.Posts;
using System.Text;

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
        [Fact]
        public async Task Create_Post_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.PostAsync("/Post"
                , new StringContent(
                JsonConvert.SerializeObject(new CreatePostCommand()
                {
                    Content = "Test",
                    Title="TestTitle"
                }),
            Encoding.UTF8,
            "application/json"));
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }
        [Fact]
        public async Task Update_Post_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.PutAsync("/Post"
                , new StringContent(
                JsonConvert.SerializeObject(new UpdatePostCommand()
                {
                    Id=1,
                    Content = "Test",
                    Title = "TestTitle"
                }),
            Encoding.UTF8,
            "application/json"));
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }
        [Fact]
        public async Task Delete_Post_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.DeleteAsync("/Post/1");
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.NoContent, responseMessage.StatusCode);
        }
    }
}
