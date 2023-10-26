using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle
    {
        // Field
        private double _radius;

        // Property
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }

                else if (value == 0)
                {
                    throw new InvalidRadiusException();
                }

                else
                {
                    throw new InvalidRadiusException(value);
                }
            }
        }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overriding ToString() method
        public override string ToString()
        {
            return string.Format("The radius of the circle is {0} and this is an acceptable value!", Radius);
        }
    }
}
