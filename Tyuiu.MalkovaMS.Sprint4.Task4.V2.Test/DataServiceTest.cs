using Tyuiu.MalkovaMS.Sprint4.Task4.V2.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] {{ 2, 2, 5, 5, 9 },
                                          { 7, 3, 8, 8, 9 },
                                          { 6, 7, 9, 3, 5 },
                                          { 7, 5, 7, 7, 8 },
                                          { 2, 2, 4, 7, 9 }};

            int[,] res = new int[5, 5]   {{ 2, 2, 0, 0, 0 },
                                          { 0, 0, 8, 8, 0 },
                                          { 6, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 8 },
                                          { 2, 2, 4, 0, 0 }};
            CollectionAssert.AreEqual(res, ds.Calculate(array));
        }
    }
}
