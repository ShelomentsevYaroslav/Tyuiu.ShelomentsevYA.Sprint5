using System;
using System.IO;
using Tyuiu.ShelomentsevYA.Sprint5.Task3.V23.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                    *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дано выражение. Вычислить его значение при x = 3.                     *");
            Console.WriteLine("* Результат сохранить в бинарный файл OutPutFileTask3.bin               *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int x = 3;

            DataService ds = new DataService();
            string filePath = ds.SaveToFileTextData(x);

            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(filePath);
            Console.WriteLine();

           
            double result;
            using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                result = br.ReadDouble();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"y(3) = {result}");
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
