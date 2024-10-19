using Tyuiu.MorozovSM.Sprint4.Task1.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива. С клавиатуры: 1, 2, 5, 3, 4, 7, 8, 8, 3, 9  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите колличество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение "+i+" элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");
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
            Console.WriteLine("Произведение нечетных чисел = " + res);
            Console.ReadKey();
        }
    }
}
