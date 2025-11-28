using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task2.V16.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3x3, заполненный значениями с       *");
            Console.WriteLine("* клавиатуры. Положительные элементы заменить на 1, отрицательные на 0.  *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы массива 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            DataService ds = new DataService();
            string filePath = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл успешно сохранён: {filePath}");
            Console.WriteLine();
            Console.WriteLine("Полученная таблица:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int val = matrix[i, j] > 0 ? 1 : 0;
                    Console.Write(val + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
