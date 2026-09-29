
using Tyuiu.RomanovMV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.RomanovMV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;
            double wait = 106.68;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);


        }
    }
}
