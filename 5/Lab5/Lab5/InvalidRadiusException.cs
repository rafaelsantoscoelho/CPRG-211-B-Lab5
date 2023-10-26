using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        {
            Console.WriteLine("InvalidRadiusException: Radius is <= 0!");
        }

        public InvalidRadiusException(double radius) : base(string.Format("InvalidRadiusException: Radius is {0} and this is an unacceptable value!", radius))
        {
        }
    }
}
