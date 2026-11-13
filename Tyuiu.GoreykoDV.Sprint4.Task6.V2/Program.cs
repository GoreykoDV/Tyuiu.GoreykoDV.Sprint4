using Tyuiu.GoreykoDV.Sprint4.Task6.V2.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GoreykoDV.Sprint4.Task6.V2
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
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан строковый массив данных [\"Белый\", \"Черный\", \"Зеленый\",         *");
            Console.WriteLine("* \"Синий\", \"Красный\", \"Желтый\", \"Фиолетовый\"] используя класс Array*");
            Console.WriteLine("* выведите элементы массива, длина которых больше 5 символов.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            var color = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= color.Length - 1; i++)
            {
                Console.Write($"{color[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string[] res = ds.Calculate(color);

            Console.WriteLine("Элементы массива, длина которых больше 5 символов:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
