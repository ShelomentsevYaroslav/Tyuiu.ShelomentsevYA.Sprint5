using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y;

                    double denominator = 2.0;
                    if (denominator == 0)
                    {
                        y = 0;
                    }
                    else
                    {

                        y = Math.Sin(x) + Math.Cos(2 * x) / denominator - 1.5 * x;
                    }

                    string line = Math.Round(y, 2)
                        .ToString(CultureInfo.InvariantCulture);

                    writer.WriteLine(line);
                }
            }

            return path;
        }
    }
}
