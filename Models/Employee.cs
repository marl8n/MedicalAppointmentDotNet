using System;

namespace MedicalAppointmentDotNet.Models
{
    public class Employee : BaseUser
    {
        public Employee()
        {
            
        }
        public Employee(
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