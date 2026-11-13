using Tyuiu.GoreykoDV.Sprint4.Task1.V18.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };

            int res = ds.Calculate(numsArray);
            
            Assert.AreEqual(79, res);
        }
    }
}
