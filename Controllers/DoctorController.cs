using System;
using System.Collections.Generic;
using System.Linq;
using MedicalAppointmentDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentDotNet.Controllers
{
    public class DoctorController : Controller
    {
        //List = SearchDoctors()
        List<Doctor> doctors = new List<Doctor>{
            new Doctor("Julion", "Alvarez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Marlon", "Zorrentino", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Ivan", "Perez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Juan", "Juarez", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
            new Doctor("Neíl", "Florentino", "Av. siempre viva, zona 2, 0-91", "12345678", DateTime.Now, Specialties.Neurology),
        };
        
        public IActionResult Index()
        {
            var NewList = doctors.Where(d => d.FirstName == "Marlon").ToList();
            return View(NewList);
        }
    }
}