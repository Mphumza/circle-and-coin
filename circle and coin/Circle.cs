using System.Buffers;
  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_and_coin
{
    internal class Circle
    {

            protected double Radius;
            public double propRadius
            {
                set { Radius = value; }
                get { return Radius; }
            }

            public double Weight;
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double rad)
        {
            Radius = rad;

        }
        public double calcArea()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
        public double calcPerimeter()
        {
            return (2 * Math.PI * Radius);
        }
    }
}










