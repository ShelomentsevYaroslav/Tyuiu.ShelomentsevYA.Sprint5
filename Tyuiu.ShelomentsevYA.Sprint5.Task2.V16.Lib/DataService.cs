using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {

            string dir = Path.GetTempPath();
            string file = Path.Combine(dir, "OutPutFileTask2.csv");

            List<string> list = new List<string>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<string> row = new List<string>();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value = matrix[i, j];
                    value = value > 0 ? 1 : 0;
                    row.Add(value.ToString());
                }

                list.Add(string.Join(";", row));
            }

            // ТЕСТ ХОЧЕТ В ОДНУ СТРОКУ
            string result = string.Join(" ", list);

            File.WriteAllText(file, result);

            return file;
        }
    }
}
