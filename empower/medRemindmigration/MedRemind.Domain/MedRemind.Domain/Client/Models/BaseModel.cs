using System;
using System.Collections.Generic;
using System.Text;

namespace MedRemind.Domain.Client.Models
{
    class BaseModel
    {
        public int Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
