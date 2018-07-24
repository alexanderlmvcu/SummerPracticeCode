using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.Domain.Client.Models
{
    class Doctor : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string EmailAddress { get; set; }
        public string OfficePhoneNumber { get; set; }
    }
}
