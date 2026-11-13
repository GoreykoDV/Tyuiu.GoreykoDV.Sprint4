using Tyuiu.GoreykoDV.Sprint4.Task2.V7.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task2.V7
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
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму                        *");
            Console.WriteLine("* четных элементов массива.                                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArry[i] = rnd.Next(4,9);
            }
                        
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArry[i] + "\t");
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
