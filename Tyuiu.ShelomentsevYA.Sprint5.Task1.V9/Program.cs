using System;
using System.Globalization;
using System.IO;
using Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание 1                                                               *");
            Console.WriteLine("* Вариант 9                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулировать функцию F(x) на [-5;5] с шагом 1.                          *");
            Console.WriteLine("* При делении на ноль возвращать 0.                                       *");
            Console.WriteLine("* Значения округлить до двух знаков.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(path);

            Console.WriteLine("\nТаблица значений:\n");

            string[] lines = File.ReadAllLines(path);
            int x = -5;

            Console.WriteLine("   x     |   F(x)");
            Console.WriteLine("-------------------------");

            foreach (string line in lines)
            {
                Console.WriteLine($"{x,5}   |   {line}");
                x++;
            }

            Console.WriteLine("\nГотово!");
            Console.ReadKey();
        }
    }
}
