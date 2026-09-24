
using Microsoft.VisualBasic;
using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovMV.Sprint1.Task2.V5.Lib
{
    public class DataService : ISprint1Task2V5
    {
        public int CalculateSideSquare(int value)
        {
            return value * value * 6;
        }
    }
}
