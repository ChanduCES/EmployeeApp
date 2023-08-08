using EmployeeApp.API.Constants;


namespace EmployeeApp.IntegrationTest
{
    public class HealthCheckIntegrationTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public HealthCheckIntegrationTest(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task HealthCheck_WhenCalled_ShouldReturnOKStatus()
        {
            //Act
            var actual = await _httpClient.GetAsync($"{Endpoints.BaseUrl}/{Endpoints.HealthCheck}");

            //Assert
            actual.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
