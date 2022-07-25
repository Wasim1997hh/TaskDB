using FirstTaskDB.Service;
using Microsoft.AspNetCore.Mvc;

namespace FirstTaskDB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            return Ok(_employeeService.Get(Id));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _employeeService.Delete(Id);
            return Ok("Deleted");
        }
    }
}
