using Tyuiu.MorozovSM.Sprint4.Task4.V16.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные          *");
            Console.WriteLine("* элементы массива на 1.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите колличество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Введите значение " + i+","+j + " элемента массива: ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++) Console.Write(array[i, j] + "\t");
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(array);
            Console.WriteLine("Массив: ");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(0); j++) Console.Write(res[i, j] + "\t");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
