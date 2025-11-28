using System.Globalization;
using Tyuiu.ShelomentsevYA.Sprint5.Task0.V3.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint5.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path));

            string txt = File.ReadAllText(path);
            double result = double.Parse(txt, CultureInfo.InvariantCulture);

            Assert.AreEqual(-1, result);
        }
    }
}
