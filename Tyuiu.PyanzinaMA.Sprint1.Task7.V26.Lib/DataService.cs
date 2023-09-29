using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PyanzinaMA.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            var z = ((Math.Sin(Math.Pow(x, x)) + y) / (y + 1)) - ((x * y - 12) / (34 + Math.Pow(x, x)));
            z = Math.Round(z, 3);
            return z;
        }
    }
}
