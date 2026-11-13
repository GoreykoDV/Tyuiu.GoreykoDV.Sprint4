using Tyuiu.GoreykoDV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный  двумерный целочисленный массив 5 на 5 элементов          *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 4                 *");
            Console.WriteLine("* Найти количество положительных элементов.                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("****************************************************************************");


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-4, 4);
                }

            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Кол-во положительных элементов = " + res);

            Console.ReadKey();
        }
    }
}
