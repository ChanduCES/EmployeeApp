using EmployeeApp.API.Constants;

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

            //Assert
            actual.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
