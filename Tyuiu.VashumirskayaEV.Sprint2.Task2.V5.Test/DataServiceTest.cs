using Tyuiu.VashumirskayaEV.Sprint2.Task2.V5.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(1, 1);
            Assert.AreEqual(false, res);
        }
    }
}
