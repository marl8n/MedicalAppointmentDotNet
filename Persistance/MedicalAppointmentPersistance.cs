using System.Collections.Generic;
using System.IO;
using MedicalAppointmentDotNet.Models;
using Newtonsoft.Json;

namespace MedicalAppointmentDotNet.Persistance
{
    public class MedicalAppointmentPersistance
    {
        public static List<MedicalAppointment> Load(string FileName = "MedicalAppointment.json")
        {
            if (File.Exists(FileName))
            {
                using(var sr = new StringReader(FileName))
                {
                    var medicalAppointments = JsonConvert.DeserializeObject<List<MedicalAppointment>>(sr.ReadToEnd());
                    if ( medicalAppointments != null )
                    {
                        return medicalAppointments;
                    }
                }
            }

            return new List<MedicalAppointment>();
        }
        public static void Save(List<MedicalAppointment> medicalAppointments, string FileName = "MedicalAppointment.json")
        {
            using( var sw = new StreamWriter(FileName) )
            {
                sw.Write(JsonConvert.SerializeObject(medicalAppointments));
            }
        }
    }
}