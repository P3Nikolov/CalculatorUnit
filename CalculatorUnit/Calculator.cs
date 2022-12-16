using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnit
{
    public class Calculator
    {
        public double Sum(int n1, int n2)
        {
            return n1 +n2;
        }
        public double Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public double Mult(int n1, int n2)
        {
            return n1 * n2;
        }
        public double Devd(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Делене на 0!!");
            }
            return (double)n1/ n2;
        }
        public double Power(int n1, int n2)
        {
            for (int i = 0; i < n2; i++)
            {
                n1 *= n1;
            }
            return n1;
        }
        public double Fact(int n1)
        {
            if (n1 < 0)
            {
                throw new ArgumentException("Can't Factoriel negative num");
            }
            int count = 1;
            for (int i = 0; i < n1; i++)
            {
                n1 *= count;
                count++;
            }
            return n1;
        }

    }
}
