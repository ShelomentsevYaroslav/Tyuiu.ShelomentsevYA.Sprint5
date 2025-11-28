using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CorrectValues()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            string path = ds.SaveToFileTextData(start, stop);

            Assert.IsTrue(File.Exists(path));

            string txt = File.ReadAllText(path);

            string expected =
                "8,04\n" +
                "6,68\n" +
                "4,84\n" +
                "1,76\n" +
                "0,45\n" +
                "0,5\n" +
                "-0,87\n" +
                "-2,42\n" +
                "-3,88\n" +
                "-6,83\n" +
                "-8,88";

            Assert.AreEqual(expected, txt);
        }
    }
}
