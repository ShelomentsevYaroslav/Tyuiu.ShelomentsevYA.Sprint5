using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            int count = 0;

            foreach (char c in text)
            {
                if (c == '?')
                    count++;
            }

            return count;
        }
    }
}
