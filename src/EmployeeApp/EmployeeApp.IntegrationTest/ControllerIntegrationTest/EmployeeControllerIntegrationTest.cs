using EmployeeApp.API.Constants;

namespace EmployeeApp.IntegrationTest.ControllerIntegrationTest
{
    public class EmployeeControllerIntegrationTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;
        public EmployeeControllerIntegrationTest(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task ShouldGetEmployeeList_WhenCalled_GetAllEmployeesAsync()
        {
            //Act
            var actual = await _httpClient.GetAsync($"{ApiRoutes.BaseUrl}/{ApiRoutes.Employee}");

            //Assert
            actual.StatusCode.Should().Be( HttpStatusCode.OK );
        }
    }
}
