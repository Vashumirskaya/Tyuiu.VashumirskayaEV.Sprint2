using Tyuiu.VashumirskayaEV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res1 = ds.FindMonthName(1990, 1);
            string wait1 = "январь";
            Assert.AreEqual(wait1, res1);
        }
    }
}
