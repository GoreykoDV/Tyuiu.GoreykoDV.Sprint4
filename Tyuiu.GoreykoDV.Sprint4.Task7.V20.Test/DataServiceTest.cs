using Tyuiu.GoreykoDV.Sprint4.Task7.V20.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "357951248632587";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            
            Assert.AreEqual(6144,res);
        }
    }
}
