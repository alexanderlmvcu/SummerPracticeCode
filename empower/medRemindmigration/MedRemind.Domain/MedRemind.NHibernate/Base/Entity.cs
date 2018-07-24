using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Base
{
    public class Entity
    {
        public virtual int Id { get; set; }
        public virtual DateTime LastUpdate { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
