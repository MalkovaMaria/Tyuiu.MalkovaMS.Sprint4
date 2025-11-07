using Tyuiu.MalkovaMS.Sprint4.Task0.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");

        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму четных  *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int[] numsArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.Write(numsArray[i] + " ");
        }
        Console.WriteLine();
        int res = ds.GetSumEvenArrEl(numsArray);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма четных элементов массива: " + res);
        Console.ReadKey();
    }
}