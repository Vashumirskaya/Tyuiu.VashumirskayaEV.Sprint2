using Tyuiu.VashumirskayaEV.Sprint2.Task5.V12.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string res = ds.FindDateOfPreviousDay(2024, 5, 15);
            string wait = "14.5.2024";
            Assert.AreEqual(wait, res);
        }
    }
}
