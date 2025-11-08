using Tyuiu.MalkovaMS.Sprint4.Task3.V13.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {{ 4, 7, 4, 2, 1},
                                           { 6, 7, 3, 6, 5},
                                           { 6, 5, 3, 3, 5},
                                           { 4, 4, 6, 4, 7},
                                           { 2, 1, 2, 3, 4}};

            Assert.AreEqual(18, ds.Calculate(matrix));
        }
    }
}
