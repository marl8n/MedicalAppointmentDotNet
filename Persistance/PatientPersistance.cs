using System.Collections.Generic;
using System.IO;
using MedicalAppointmentDotNet.Models;
using Newtonsoft.Json;

namespace MedicalAppointmentDotNet.Persistance
{
    public class PatientPersistance
    {
        static List<Patient> Load(string FileName = "Patient.json")
        {
            if (File.Exists(FileName))
            {
                using (var sr = new StreamReader(FileName))
                {
                    var patients = JsonConvert.DeserializeObject<List<Patient>>(sr.ReadToEnd());
                    if (patients != null)
                    {
                        return patients;
                    }
                }
            }

            return new List<Patient>();
        }

        static void Save(List<Patient> patients, string FileName = "Patient.json")
        {
            using (var sw = new StreamWriter(FileName))
            {
                sw.Write(JsonConvert.SerializeObject(patients));
            }
        }
    }
}