using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoreykoDV.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrx = new int[n, m];
                        
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 1;
            for (int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (matrx[i,j] %2 == 0)
                    {
                        count *= matrx[i, j];
                    }
                }
            }

            return count;
        }
    }
}
