using System;
using Tyuiu.ShelomentsevYA.Sprint5.Task0.V3.Lib;

namespace Tyuiu.ShelomencevYA.Sprint5.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                         *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение, вычислить его при x = 3. Результат сохранить в файл      *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести путь к файлу.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            int x = 3;

            string filePath = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл успешно сохранён по пути:\n{filePath}");

            Console.ReadKey();
        }
    }
}
