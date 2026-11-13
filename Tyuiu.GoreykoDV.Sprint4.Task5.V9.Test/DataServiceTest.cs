using Tyuiu.GoreykoDV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {{-2, 3, -1, 2, 0},
                                         {4, -3, 1, -2, 3},
                                         {-1, 0, 2, -4, 1},
                                         {3, -2, 4, 0, -1},
                                         {-3, 2, -1, 3, 2}};

            int res = ds.Calculate(mas2);

            Assert.AreEqual(12, res);
        }
    }
}
