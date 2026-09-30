
using Tyuiu.RomanovMV.Sprint1.Task7.V7.Lib;

namespace Tyuiu.RomanovMV.Sprint1.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = -9.288;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 1e-3);


        }
    }
}
