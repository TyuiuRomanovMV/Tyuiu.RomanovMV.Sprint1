
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovMV.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string value2 = value.Replace(" ", "").ToLower();
            char[] value3 = value2.ToCharArray();
            Array.Reverse(value3);
            string reversed = new string(value3);
            bool result = string.Equals(reversed, value2);
            return result;
        }
    }
}
