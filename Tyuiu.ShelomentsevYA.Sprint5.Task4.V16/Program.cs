using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task4.V16.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Из файла C:\\DataSprint5\\InPutDataFileTask4V16.txt прочитать значение x,*");
            Console.WriteLine("* вычислить y = cos(x) + x^2 - (2x / 1.2).                               *");
            Console.WriteLine("* Округлить результат до трёх знаков после запятой.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string inputPath = @"C:\DataSprint5\InPutDataFileTask4V16.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(inputPath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"y = {result}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
