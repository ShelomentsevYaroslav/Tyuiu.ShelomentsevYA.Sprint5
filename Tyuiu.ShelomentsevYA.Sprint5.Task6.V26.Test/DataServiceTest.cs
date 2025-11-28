using Tyuiu.ShelomentsevYA.Sprint5.Task6.V26.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint5.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string temp = Path.GetTempPath();
            string filePath = Path.Combine(temp, "task6_v26_test.txt");

            File.WriteAllText(filePath,
                "Это? Не просто? Строка? С восклицательными знаками???");

            DataService ds = new DataService();

            int result = ds.LoadFromDataFile(filePath);

            int expected = 6;

            Assert.AreEqual(expected, result);
        }
    }
}
