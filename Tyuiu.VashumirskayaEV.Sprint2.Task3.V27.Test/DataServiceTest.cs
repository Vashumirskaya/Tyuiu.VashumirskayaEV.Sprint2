using Tyuiu.VashumirskayaEV.Sprint2.Task3.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }
    }
}
