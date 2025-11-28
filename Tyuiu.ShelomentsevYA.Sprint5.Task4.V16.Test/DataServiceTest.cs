using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint5.Task4.V16.Lib;
using System.IO;
using System.Globalization;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CheckCalculation()
        {
            string inputPath = @"C:\DataSprint5\InPutDataFileTask4V16.txt";

            DataService ds = new DataService();

            double result = ds.LoadFromDataFile(inputPath);

            double x = double.Parse(File.ReadAllText(inputPath).Trim(),
                                    CultureInfo.InvariantCulture);

            double expected = Math.Round(Math.Cos(x) + Math.Pow(x, 2) - (2 * x / 1.2), 3);

            Assert.AreEqual(expected, result);
        }
    }
}
