using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRechner
{
    public static class Rechner
    {
        public static float add(float a, float b)
        {
            return a + b;
        }

        public static float divide(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
