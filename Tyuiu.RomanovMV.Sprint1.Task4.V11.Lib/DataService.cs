
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovMV.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            var resssult = (Math.Atan(x) / Math.Pow(Math.E, y));
            var result = Math.Round(resssult, 3);
            return result;
        }
    }
}
