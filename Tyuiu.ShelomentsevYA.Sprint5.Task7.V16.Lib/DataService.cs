using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' },
                                        StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 2)
                    words[i] = "XY";
            }

            string result = string.Join(" ", words);

            string tempPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V16.txt");

            File.WriteAllText(tempPath, result);

            return tempPath;
        }
    }
}
