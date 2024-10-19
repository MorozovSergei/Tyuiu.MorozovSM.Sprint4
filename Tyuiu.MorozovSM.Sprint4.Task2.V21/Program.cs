using Tyuiu.MorozovSM.Sprint4.Task2.V21.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных         *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите колличество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = random.Next(1,8);
            }
            Console.Write("Массив: ");
            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }
            Console.Write("\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(array);
            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
