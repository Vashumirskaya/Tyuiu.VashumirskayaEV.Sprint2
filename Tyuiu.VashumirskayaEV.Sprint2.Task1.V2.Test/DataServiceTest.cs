using Tyuiu.VashumirskayaEV.Sprint2.Task1.V2.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] res = ds.GetLogicOperations(135, 156, 154, 174);
            bool[] wait = new bool[6]
            {
                true, true, true, true, true, false
            };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
