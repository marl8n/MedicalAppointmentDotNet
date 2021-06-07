using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MedicalAppointmentDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class DoctorController : Controller
    {
        //List = SearchDoctors()
        static List<Doctor> doctors = new List<Doctor>{
            new Doctor("Julion", "Alvarez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Marlon", "Zorrentino", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Ivan", "Perez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Juan", "Juarez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Neíl", "Florentino", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
        };
        
        public IActionResult Index()
        {
            return View(doctors);
        }
        public IActionResult CreateDoctor() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor) 
        {
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
            return View();
        }
    }
}