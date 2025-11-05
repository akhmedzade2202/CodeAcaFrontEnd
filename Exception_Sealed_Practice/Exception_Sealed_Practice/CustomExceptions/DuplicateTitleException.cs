using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Sealed_Practice.CustomExceptions
{
    internal class DuplicateTitleException : Exception
    {
        public DuplicateTitleException(string message) : base(message) { }
    }
}
