using System;
using MedicalAppointmentDotNet.Models.Utils;

namespace MedicalAppointmentDotNet.Models
{
    public class MedicalAppointment : BaseObject
    {
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public string PatientId { get; set; }
        public DateTime Date { get; set; }
        public MedicalAppointment()
        {
            
        }
        public MedicalAppointment(DateTime Date, string DoctorId, string PatientId) : base(true)
        {
            this.Date = Date;
            this.DoctorId = DoctorId;
            this.PatientId = PatientId;
            this.Doctor = AppointmentUtils.JoinDoctor(DoctorId.Trim());
            this.Patient = AppointmentUtils.JoinPatient(PatientId.Trim());
        }
    }
}