using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MedicalAppointmentDotNet.Models;
using MedicalAppointmentDotNet.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class DoctorController : Controller
    {
        
        public IActionResult Index()
        {
            List<Doctor> doctors = w.Load();
            return View(doctors);
        }
        public IActionResult CreateDoctor() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor) 
        {
            List<Doctor> doctors = DoctorPersistance.Load();
            doctors.Add(
                new Doctor(
                    doctor.FirstName,
                    doctor.LastName,
                    doctor.Address,
                    doctor.PhoneNumber,
                    doctor.Birthdate,
                    doctor.Specialty
                )
            );
            DoctorPersistance.Save(doctors);
            return Redirect("Index");
        }
    }
}