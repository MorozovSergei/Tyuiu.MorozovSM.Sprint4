using Tyuiu.MorozovSM.Sprint4.Task7.V28.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 623351179845632. Преобразуйте ее в    *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = 3;
            int columns = 5;
            string str = "623351179845632";
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(str[i*rows+j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(rows,columns,str);
            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
