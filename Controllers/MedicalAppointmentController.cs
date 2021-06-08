using MedicalAppointmentDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class MedicalAppointmentController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult CreateMedicalAppointment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMedicalAppointment(MedicalAppointment medicalAppointment)
        {
            return Redirect("Index");
        }
    }
}