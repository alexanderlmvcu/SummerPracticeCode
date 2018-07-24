using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;


namespace MedRemind.NHibernate.Entities
{
    class Doctor : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Specialty { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string OfficePhoneNumber { get; set; }
    }
}
