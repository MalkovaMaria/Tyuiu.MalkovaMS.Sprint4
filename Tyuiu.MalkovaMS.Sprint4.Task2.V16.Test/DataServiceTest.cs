using Tyuiu.MalkovaMS.Sprint4.Task2.V16.Lib;
namespace Tyuiu.MalkovaMS.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = [1, 2, 8, 19];
            Assert.AreEqual(20, ds.Calculate(array));
        }
    }
}
