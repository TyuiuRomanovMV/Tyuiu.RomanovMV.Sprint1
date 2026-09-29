using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovMV.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            double km = verst * 1066.8 / 1000;
            double result = Math.Round(km, 3);
            return result;
        }
    }
}