using System.Collections.Generic;
using System.IO;
using MedicalAppointmentDotNet.Models;
using Newtonsoft.Json;

namespace MedicalAppointmentDotNet.Persistance
{
    public class DoctorPersistance
    {
        static List<Doctor> Load(string FileName = "Doctors.json")
        {
            if (File.Exists(FileName))
            {
                using(var sr = new StreamReader(FileName))
                {
                    var doctors = JsonConvert.DeserializeObject<List<Doctor>>(sr.ReadToEnd());
                    if (doctors != null)
                    {
                        return doctors;
                    }
                }
            }

            return new List<Doctor>();
        }

        static void Save(List<Doctor> doctors, string FileName = "Doctors.json")
        {
            using(var sw = new StreamWriter(FileName))
            {
                sw.Write(JsonConvert.SerializeObject(doctors));
            }
        }
    }
}