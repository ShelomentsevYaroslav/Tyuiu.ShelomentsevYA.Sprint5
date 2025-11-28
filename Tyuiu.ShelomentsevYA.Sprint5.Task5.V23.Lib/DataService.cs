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
            string raw = File.ReadAllText(path).Trim();

            string[] parts = raw.Split(new char[] { ' ', '\n', '\r', '\t' },
                                       StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;

            foreach (string part in parts)
            {
                double value = double.Parse(part, CultureInfo.InvariantCulture);

                if (value < min)
                    min = value;
            }

            return Math.Round(min, 3);
        }
    }
}
