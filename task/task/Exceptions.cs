using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class ReservedDateInterval : Exception
    {
        public ReservedDateInterval(string message) : base(message)
        {

        }
    }
    internal class WrongDateInterval : Exception
    {
        public WrongDateInterval(string message) : base(message)
        {

        }
    }
}
