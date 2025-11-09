using Tyuiu.MalkovaMS.Sprint4.Task5.V27.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[2, 2] { { -3, 5 }, { 1, -5 } };
            Assert.AreEqual(2, ds.Calculate(matrix));
        }
    }
}
