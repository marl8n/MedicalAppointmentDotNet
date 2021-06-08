using MedicalAppointmentDotNet.Models;
using MedicalAppointmentDotNet.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class MedicalAppointmentController : Controller
    {
        public IActionResult Index() 
        {
            var medicalAppointments = MedicalAppointmentPersistance.Load();
            return View(medicalAppointments);
        }
        public IActionResult CreateMedicalAppointment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMedicalAppointment(MedicalAppointment medicalAppointment)
        {
            var medicalAppointments = MedicalAppointmentPersistance.Load();
            medicalAppointments.Add(
                new MedicalAppointment(
                    medicalAppointment.Date,
                    medicalAppointment.DoctorId,
                    medicalAppointment.PatientId
                )
            );
            MedicalAppointmentPersistance.Save(medicalAppointments);
            return Redirect("Index");
        }
    }
}