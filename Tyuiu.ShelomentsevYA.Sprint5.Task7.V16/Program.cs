using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task7.V16.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод обработки символьных данных                      *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Заменить все слова длиной 2 символа на 'XY' и сохранить результат.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V16.txt";

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(outputPath);
            Console.WriteLine();

            Console.WriteLine("Содержимое:");
            Console.WriteLine(File.ReadAllText(outputPath));

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
