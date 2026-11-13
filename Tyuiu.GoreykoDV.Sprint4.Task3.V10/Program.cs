using Tyuiu.GoreykoDV.Sprint4.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GoreykoDV.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] {{5, 7, 6, 6, 5},
                                         {5, 5, 5, 4, 6},
                                         {8, 5, 7, 4, 7},
                                         {7, 6, 7, 4, 7},
                                         {5, 8, 7, 8, 8}};


            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            DataService ds = new DataService();
            

            Console.Title = "Спринт #4 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный  двумерный целочисленный массив 5 на 5 элементов          *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 8                *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)          
            {
                for (int j = 0; j < columns; j++)   
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Большое значение в 3 строке: " + res);
            Console.ReadKey();
        }
    }
}
