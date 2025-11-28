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

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denom = 1.5 * x;

                    double result;

                    if (denom == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = (Math.Sin(x) + Math.Cos(2 * x) / 2) / (1.5 * x);
                    }

                    result = Math.Round(result, 2);

                    sw.WriteLine(result.ToString(CultureInfo.InvariantCulture));
                }
            }

            return path;
        }
    }
}
