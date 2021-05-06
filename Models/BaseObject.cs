using System;

namespace MedicalAppointmentDotNet.Models
{
    public class BaseObject
    {
        public string UniqueId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BaseObject()
        {

        }
        public BaseObject(bool IsNew)
        {
            if (IsNew)
            {
                this.UniqueId = Guid.NewGuid().ToString();
                this.CreatedAt = DateTime.Now;
                this.UpdatedAt = DateTime.Now;
            }
        }
        public void ActualizeDate()
        {
            this.UpdatedAt = DateTime.Now;
        }
    }
}