using MedicalAppointmentDotNet.Models;
using MedicalAppointmentDotNet.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = EmployeePersistance.Load();
            return View(employees);
        }
        public IActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            var employees = EmployeePersistance.Load();
            employees.Add(new Employee(
                employee.FirstName,
                employee.LastName,
                employee.Address,
                employee.PhoneNumber,
                employee.Birthdate
            ));
            EmployeePersistance.Save(employees);
            return Redirect("Index");
        }
    }
}