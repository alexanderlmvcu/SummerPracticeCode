using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Entities
{
    class Medicine : Entity
    {
        public virtual string MedicineName { get; set; }
    }
}
