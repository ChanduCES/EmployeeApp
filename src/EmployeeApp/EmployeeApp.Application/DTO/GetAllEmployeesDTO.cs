using System.Data;

namespace EmployeeApp.Application.DTO
{
    public class GetAllEmployeesDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
