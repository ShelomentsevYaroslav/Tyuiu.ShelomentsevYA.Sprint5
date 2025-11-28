using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.IO;
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

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Файл должен существовать
            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            // Должно быть 11 строк от -5 до 5 включительно
            Assert.AreEqual(stopValue - startValue + 1, lines.Length);

            // Ожидаемые значения по формуле из ТЗ
            double[] expected =
            {
                8.04, 6.68, 4.84, 1.76, 0.45,
                0.50, -0.87, -2.42, -3.88, -6.83, -8.88
            };

            for (int i = 0; i < expected.Length; i++)
            {
                double actual = double.Parse(lines[i], CultureInfo.InvariantCulture);
                Assert.AreEqual(expected[i], actual, 0.01);
            }
        }
    }
}
