using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Entities
{
    class Caregiver
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual Int64 PhoneNumber { get; set; }
    }
}
