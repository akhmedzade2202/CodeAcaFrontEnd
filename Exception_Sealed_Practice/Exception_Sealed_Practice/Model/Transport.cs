using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Sealed_Practice.Model
{
    internal  class Transport : BaseEntity
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string title { get; set; }

        
    }
}
