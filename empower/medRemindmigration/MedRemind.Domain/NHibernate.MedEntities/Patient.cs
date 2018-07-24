using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;

namespace NHibernate.MedEntities
{
    public class Patient : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual Int64 PhoneNumber { get; set; }
    }
}
