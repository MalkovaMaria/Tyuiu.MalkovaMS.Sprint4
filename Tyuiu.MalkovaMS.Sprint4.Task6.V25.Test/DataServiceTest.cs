using Tyuiu.MalkovaMS.Sprint4.Task6.V25.Lib;

namespace Tyuiu.MalkovaMS.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            Assert.AreEqual(2, ds.Calculate(array));
        }
    }
}
