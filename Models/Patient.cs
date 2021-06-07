using System;

namespace MedicalAppointmentDotNet.Models
{
    public class Patient : BaseUser
    {
        public Patient()
        {
            
        }
        public Patient(
            string FirstName,
            string LastName,
            string Address,
            string PhoneNumber,
            DateTime Birthdate
            ):base(
                FirstName,
                LastName,
                Address,
                PhoneNumber,
                Birthdate
            )
        {
            
        }
    }
}