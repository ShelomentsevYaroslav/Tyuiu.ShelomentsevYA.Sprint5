using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint5.Task7.V16.Lib;
using System.IO;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave_CorrectReplacement()
        {
            string temp = Path.GetTempPath();
            string inputPath = Path.Combine(temp, "task7v16_input.txt");

            File.WriteAllText(inputPath, "Это is just a sample строки in English.");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            string result = File.ReadAllText(outputPath);

            string expected = "Это XY just a sample строки XY English.";

            Assert.AreEqual(expected, result);
        }
    }
}
