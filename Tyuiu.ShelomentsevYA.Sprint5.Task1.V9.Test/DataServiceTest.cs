using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(11, lines.Length);

            foreach (string line in lines)
            {
                bool ok = double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out _);
                Assert.IsTrue(ok);
            }
        }
    }
}
