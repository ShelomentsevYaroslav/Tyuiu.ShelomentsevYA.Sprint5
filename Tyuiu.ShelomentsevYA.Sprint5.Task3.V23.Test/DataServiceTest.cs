using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint5.Task3.V23.Lib;
using System.IO;

namespace Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CorrectValue()
        {
            
            DataService ds = new DataService();
            int x = 3;

            
            double expected = 3.111;

            
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            double value;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = reader.ReadDouble();
            }

            
            Assert.AreEqual(expected, value);
        }
    }
}
