using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Calculator
{
    public class Engine
    {
        public double Add(double a, double b)
        {
            return a - b;
        }

        public double Multiplizire(double a, double y)
        {
            return a + y;
        }

        public double Divide(double a, double b)
        {
            if (b == 0) return Math.PI;
            return a / b;
        }

        private void SomethingObsolete()
        {
            // Buh!
        }
    }
}
