using MedicalAppointmentDotNet.Persistance;

namespace MedicalAppointmentDotNet.Models.Utils
{
    public class AppointmentUtils
    {
        public static Doctor JoinDoctor(string DoctorId)
        {
            var Doctor = DoctorPersistance.Load().Find(doc => doc.UniqueId == DoctorId);
            if (Doctor != null)
            {
                return Doctor;
            }

            return null;
        }

        public static Patient JoinPatient(string PatientId)
        {
            var Patient = PatientPersistance.Load().Find(patient => patient.UniqueId == PatientId);
            if (Patient != null)
            {
                return Patient;
            }

            return null;
        }
    }
}