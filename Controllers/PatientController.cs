using MedicalAppointmentDotNet.Models;
using MedicalAppointmentDotNet.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            var patients = PatientPersistance.Load();
            return View(patients);
        }
        public IActionResult CreatePatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePatient(Patient patient)
        {
            var patients = PatientPersistance.Load();
            patients.Add(new Patient(
                patient.FirstName,
                patient.LastName,
                patient.Address,
                patient.PhoneNumber,
                patient.Birthdate
            ));
            PatientPersistance.Save(patients);
            return Redirect("Index");
        }
    }
}