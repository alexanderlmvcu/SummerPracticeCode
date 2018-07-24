using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.Domain.Client.Models
{
    class Patient : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Int64 PhoneNumber { get; set; }
    }
}
