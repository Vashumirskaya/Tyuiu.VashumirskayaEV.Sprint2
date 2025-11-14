using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.VashumirskayaEV.Sprint2.Task4.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            double wait = 8;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
