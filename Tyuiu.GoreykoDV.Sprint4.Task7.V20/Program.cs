using Tyuiu.GoreykoDV.Sprint4.Task7.V20.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            int[,] matrx = new int[n, m];

            string str = "357951248632587";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"357951248632587\"                    *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.*");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int index = 0;

            Console.WriteLine("\n Массив: ");
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произведение четных элементов = " + res);

            Console.ReadKey();
        }
    }
}
