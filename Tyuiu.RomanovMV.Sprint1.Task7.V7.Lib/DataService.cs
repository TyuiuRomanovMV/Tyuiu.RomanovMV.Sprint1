
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovMV.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            double x1 = Math.Cos(x); double x2 = Math.PI - 2 * Math.Pow(y, x);
            double x3 = Math.Cos(x*y);
            double z = x1 / x2 + 16 * x * x3 - 2;
            return Math.Round(z, 3);
        }
    }
}
