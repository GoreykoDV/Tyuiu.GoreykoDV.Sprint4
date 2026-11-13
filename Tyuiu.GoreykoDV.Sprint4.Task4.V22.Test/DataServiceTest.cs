using Tyuiu.GoreykoDV.Sprint4.Task4.V22.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {{4, 3, 2, 4, 5},
                                         {5, 4, 5, 6, 6},
                                         {6, 2, 3, 6, 5},
                                         {6, 2, 3, 6, 4},
                                         {6, 2, 6, 6, 2}};

            int[,] res = ds.Calculate(mas2);
                        
            Assert.AreEqual(4, res[0, 0]); 
            Assert.AreEqual(0, res[0, 1]); 
            Assert.AreEqual(0, res[0, 4]); 
            Assert.AreEqual(0, res[1, 0]); 
            Assert.AreEqual(6, res[1, 3]);
        }
    }
}
