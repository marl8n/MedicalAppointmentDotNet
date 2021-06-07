using System.Collections.Generic;
using System.IO;
using MedicalAppointmentDotNet.Models;
using Newtonsoft.Json;

namespace MedicalAppointmentDotNet.Persistance
{
    public class EmployeePersistance
    {
        public static List<Employee> Load(string FileName = "Employee.json")
        {
            if (File.Exists(FileName))
            {
                using (var sr = new StreamReader(FileName))
                {
                    var employees = JsonConvert.DeserializeObject<List<Employee>>(sr.ReadToEnd());
                    if (employees != null)
                    {
                        return employees;
                    }
                }
            }

            return new List<Employee>();
        }

        public static void Save(List<Employee> employees, string FileName = "Patient.json")
        {
            using (var sw = new StreamWriter(FileName))
            {
                sw.Write(JsonConvert.SerializeObject(employees));
            }
        }
    }
}