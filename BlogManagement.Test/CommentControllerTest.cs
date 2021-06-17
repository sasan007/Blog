using BlogManagement.Core.ApplicationServices.Command.Comments;
using BlogManagement.Endpoints.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlogManagement.Test
{
    public class CommentControllerTest: IClassFixture<WebApplicationFactory<Startup>>
    {

        WebApplicationFactory<Startup> _fixture;

        public CommentControllerTest(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Get_Comment_By_Id_Should_Return_Not_Empty()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Comment/1");
            responseMessage.EnsureSuccessStatusCode();
            var content = await responseMessage.Content.ReadAsStringAsync();
            Assert.NotEqual("", content);
        }

        [Fact]
        public async Task Get_Comments_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.GetAsync("/Comment");
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }
        [Fact]
        public async Task Create_Comment_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.PostAsync("/Comment"
                , new StringContent(
                JsonConvert.SerializeObject(new CreateCommentCommand()
                {
                    Text="TestLike"
                }),
            Encoding.UTF8,
            "application/json"));
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, responseMessage.StatusCode);
        }

        [Fact]
        public async Task Delete_Comment_Should_Return_OK()
        {
            HttpClient client = _fixture.CreateClient();
            var responseMessage = await client.DeleteAsync("/Comment/1");
            responseMessage.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.NoContent, responseMessage.StatusCode);
        }
    }
}
