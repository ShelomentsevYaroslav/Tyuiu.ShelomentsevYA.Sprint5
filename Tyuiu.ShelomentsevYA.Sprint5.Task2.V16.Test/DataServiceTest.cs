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
            int[,] matrix = new int[,]
    {
        { 2, -4, -8 },
        { 3, -7, -2 },
        { 3,  8,  6 }
    };

            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(matrix);

            string result = File.ReadAllText(path);

            Assert.AreEqual("1;0;0\n1;0;0\n1;1;1", result);
        }

    }
}
