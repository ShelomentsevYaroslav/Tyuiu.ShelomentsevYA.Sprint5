using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double min = double.MaxValue;

            foreach (string line in lines)
            {
                double value = double.Parse(line.Trim(), CultureInfo.InvariantCulture);

                if (value < min)
                    min = value;
            }

            return Math.Round(min, 3);
        }
    }
}
