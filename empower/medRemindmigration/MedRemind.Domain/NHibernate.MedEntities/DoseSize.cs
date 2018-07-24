using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Entities
{
    class DoseSize : Entity
    {
        public virtual string IngestionType { get; set; }
        public virtual string Size { get; set; }
    }
}
