using Tyuiu.MalkovaMS.Sprint4.Task0.V21.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int wait = 35;
            Assert.AreEqual(wait, ds.GetSumEvenArrEl(nums));
        }
    }
}
