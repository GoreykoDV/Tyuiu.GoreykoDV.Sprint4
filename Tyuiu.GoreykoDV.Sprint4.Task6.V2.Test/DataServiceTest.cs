using Tyuiu.GoreykoDV.Sprint4.Task6.V2.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GoreykoDV.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var color = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(color);

            string[] wait = new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
