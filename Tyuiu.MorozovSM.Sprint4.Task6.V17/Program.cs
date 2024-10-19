using Tyuiu.MorozovSM.Sprint4.Task6.V17.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task6.V17
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Python, JavaScript, Java, C#, Swift,       *");
            Console.WriteLine("* Kotlin, Ruby] используя класс Array подсчитайте количество элементов,   *");
            Console.WriteLine("* длина которых равна 6.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            Console.Write("Массив: ");
            foreach (string i in array)
            {
                Console.Write(i + "\t");
            }
            Console.Write("\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(array);
            Console.WriteLine("Количество элементов с длинной 6 = "+res);
            Console.ReadKey();
        }
    }
}
