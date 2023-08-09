using EmployeeApp.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetAllEmployeesDTO>>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
