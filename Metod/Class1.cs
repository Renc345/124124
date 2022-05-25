using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    public class ms
    {
        public  double Calculate(double x, double y, double z)
        {
            double a = Math.Pow(x, 2) * Math.Pow(y, 3) * Math.Sqrt(z);
            return a;
        }
        public  bool Srav(double a, double d)
        {
            bool b = a > d;
            return b;
        }

    }
}
