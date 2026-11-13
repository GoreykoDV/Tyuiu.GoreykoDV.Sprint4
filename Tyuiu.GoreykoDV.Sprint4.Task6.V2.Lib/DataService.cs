using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoreykoDV.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, s => s.Length > 5);
        }
    }
}
