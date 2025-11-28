using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint5.Task5.V23.Lib;
using System.IO;
using System.Globalization;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CheckMinValue()
        {
            string temp = Path.GetTempPath();
            string filePath = Path.Combine(temp, "task5_v23_input_test.txt");

            File.WriteAllLines(filePath, new string[]
            {
                "10.82",
                "-4",
                "14.05",
                "-9",
                "6",
                "19.21",
                "12.49",
                "10",
                "-7.1",
                "4.92",
                "13.53",
                "17.67",
                "-6",
                "-6.99",
                "-5",
                "10",
                "-8",
                "-8",
                "15",
                "6"
            });

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(filePath);

            double expected = -9.000;

            Assert.AreEqual(expected, result);
        }
    }
}
