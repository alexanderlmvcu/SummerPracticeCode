using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Entities
{
    class MedicineClass : Entity
    {
        public virtual string MedicineClassName { get; set; }
    }
}
