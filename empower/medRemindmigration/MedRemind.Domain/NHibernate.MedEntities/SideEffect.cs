using MedRemind.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.NHibernate.Entities
{
    class SideEffect : Entity
    {
        public virtual string SideEffectName { get; set; }
    }
}
