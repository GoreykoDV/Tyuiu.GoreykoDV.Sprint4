using Tyuiu.GoreykoDV.Sprint4.Task0.V15.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds= new DataService();

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetMultOddArrEl(numsArray);

            Assert.AreEqual(138915, res);

        }
    }
}
