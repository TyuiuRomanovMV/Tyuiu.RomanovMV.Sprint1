
using Tyuiu.RomanovMV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.RomanovMV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "привет";
            bool wait = false;
            bool res = ds.CheckPalindrome(x);
            Assert.AreEqual(wait, res);
        }
    }
}
