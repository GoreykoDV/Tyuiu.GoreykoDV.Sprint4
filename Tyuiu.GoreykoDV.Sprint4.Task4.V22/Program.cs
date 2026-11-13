using Tyuiu.GoreykoDV.Sprint4.Task4.V22.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный  двумерный целочисленный массив 5 на 5 элементов          *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 6                *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                 *");
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
                    Console.Write($"Введите {i},{j}  элеммент массива: ");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
              
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int[,] res = ds.Calculate(mtrx);

            Console.WriteLine("Массив после замены нечетных элементов на 0:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{res[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
