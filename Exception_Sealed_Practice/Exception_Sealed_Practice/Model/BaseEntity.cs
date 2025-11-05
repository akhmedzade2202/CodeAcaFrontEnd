using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Sealed_Practice.Model
{
    internal abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
