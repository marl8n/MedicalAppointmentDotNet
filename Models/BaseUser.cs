using System;

namespace MedicalAppointmentDotNet.Models
{
    public class BaseUser : BaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }

        // Empty Constructor
        public BaseUser()
        {
            
        }

        // Constructor with params, extends base constructor
        public BaseUser(
            string FirstName,
            string LastName,
            string Address,
            string PhoneNumber,
            DateTime Birthdate
            ):base(true) // True, for using the params constructor
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Birthdate = Birthdate;
        }
    }
}