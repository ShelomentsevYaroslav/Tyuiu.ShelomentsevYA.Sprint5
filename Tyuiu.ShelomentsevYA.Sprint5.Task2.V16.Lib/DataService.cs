using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    List<string> lineValues = new List<string>();

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int value = matrix[i, j] >= 0 ? 1 : 0;
                        lineValues.Add(value.ToString());
                    }

                    string line = string.Join(";", lineValues);
                    writer.Write(line);       // <-- ПИШЕМ БЕЗ \r !!!
                    if (i < matrix.GetLength(0) - 1)
                        writer.Write("\n");   // <-- ВСЕГДА ТОЛЬКО \n !!!
                }
            }

            return path;
        }
    }
}
