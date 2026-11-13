using Tyuiu.GoreykoDV.Sprint4.Task1.V18.Lib;

namespace Tyuiu.GoreykoDV.Sprint4.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный          *");
            Console.WriteLine("*  с клавиатуры в диапазоне от 3 до 9 подсчитать сумму нечетных элементов  *");
            Console.WriteLine("*  массива.  С клавиатуры: 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int len;

            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("Введите значение " + i + "элемента массива: ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0;i <= len-1;i++)
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
