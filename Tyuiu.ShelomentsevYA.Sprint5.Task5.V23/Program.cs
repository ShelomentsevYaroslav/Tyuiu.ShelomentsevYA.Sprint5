using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task5.V23.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Прочитать набор вещественных значений из файла                         *");
            Console.WriteLine("* C:\\DataSprint5\\InPutDataFileTask5V23.txt.                            *");
            Console.WriteLine("* Найти минимальное значение и округлить его до трёх знаков.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальное значение: {result}");
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
