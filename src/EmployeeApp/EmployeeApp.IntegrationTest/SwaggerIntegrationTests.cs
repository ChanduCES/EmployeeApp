using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using EmployeeApp.IntegrationTest.Constants;

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
            var actual = await _httpClient.GetAsync(TestCaseConstants.SwaggerEndpoint);
            var result = await actual.Content.ReadAsStringAsync();

            var jsonObject = JsonConvert.DeserializeObject<JObject>(result);
            string title = jsonObject[TestCaseConstants.InfoJToken][TestCaseConstants.TitleJToken].ToString();

            //Assert
            actual.StatusCode.Should().Be(HttpStatusCode.OK);
            title.Should().Be(TestCaseConstants.EmployeeAppAPI);
        }
    }
}
