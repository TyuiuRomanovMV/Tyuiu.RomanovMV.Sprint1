
using Tyuiu.RomanovMV.Sprint1.Task2.V5.Lib;

namespace Tyuiu.RomanovMV.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.CalculateSideSquare(x);
            Assert.AreEqual(54, res);




        }
    }
}
