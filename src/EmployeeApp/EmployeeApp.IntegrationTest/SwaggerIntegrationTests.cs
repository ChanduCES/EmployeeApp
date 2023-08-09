using EmployeeApp.API.Constants;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EmployeeApp.IntegrationTest
{
    public  class SwaggerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public SwaggerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task SwaggerApi_WhenCalled_ShouldReturnOKStatus()
        {
            //Act
            var actual = await _httpClient.GetAsync(ApiRoutes.SwaggerEndpoint);
            var result = await actual.Content.ReadAsStringAsync();

            var json = JsonConvert.DeserializeObject<JToken>(result);
            string title = json[AppConstants.InfoJToken][AppConstants.TitleJToken].ToString();

            //Assert
            actual.StatusCode.Should().Be(HttpStatusCode.OK);
            title.Should().BeEquivalentTo(AppConstants.EmployeeAppAPI);
        }
    }
}
