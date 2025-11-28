using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint5.Task2.V16.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CorrectValues()
        {
            // arrange
            int[,] matrix = new int[,]
            {
        { 2, -4, -8 },
        { 3, -7, -2 },
        { 3,  8,  6 }
            };

            DataService ds = new DataService();

            // act
            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            // читаем содержимое
            string text = File.ReadAllText(path).Trim();

            // нормализуем переносы
            text = text.Replace("\r\n", "\n");

            string expected =
                "1;0;0\n" +
                "1;0;0\n" +
                "1;1;1";

            // assert
            Assert.AreEqual(expected, text);
        }

    }
}
