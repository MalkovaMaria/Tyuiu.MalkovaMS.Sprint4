using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MalkovaMS.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            int res = 0;

            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j == 3)
                        res += array[i, j];
                }
            }
            return res;

        }
    }
}
