using Tyuiu.GoreykoDV.Sprint4.Task2.V7.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3 };

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(32, res);
        }
    }
}
