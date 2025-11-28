using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task6.V26.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение символьных данных из файла                                *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Прочитать строку из файла и найти количество знаков вопроса '?'.       *");
            Console.WriteLine("* Файл: C:\\DataSprint5\\InPutDataFileTask6V26.txt                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество знаков вопроса: {result}");
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
