using Tyuiu.MalkovaMS.Sprint4.Task7.V13.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int cols = 3;
            string value = "159357246";
            Assert.AreEqual(3, ds.Calculate(rows, cols, value));
        }
    }
}
