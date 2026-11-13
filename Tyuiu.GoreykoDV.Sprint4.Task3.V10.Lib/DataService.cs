using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoreykoDV.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {            
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int count = 2;

            int max = array[count, 0];

            for (int j = 1; j < columns; j++)
            {
                if (array[count, j] > max)
                {
                    max = array[count, j];
                }
            }


            return max;
        }
    }
}
