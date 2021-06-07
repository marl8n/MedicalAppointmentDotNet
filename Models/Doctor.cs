using System;

namespace MedicalAppointmentDotNet.Models
{
    public class Doctor : BaseUser
    {
        public Specialties Specialty { get; set; }
        public Doctor()
        {
            
        }
        public Doctor(
            string FirstName,
            string LastName,
            string Address,
            string PhoneNumber,
            DateTime Birthdate,
            Specialties Specialty
        ):base(
            FirstName,
            LastName,
            Address,
            PhoneNumber,
            Birthdate
        )
        {
            this.Specialty = Specialty;
        }
    }
}