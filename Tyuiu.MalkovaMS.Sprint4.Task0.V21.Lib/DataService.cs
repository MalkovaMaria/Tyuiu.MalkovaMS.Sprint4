using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MalkovaMS.Sprint4.Task0.V21.Lib
{
    public class DataService : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    res += array[i];
            }
            return res;
        }
    }
}
