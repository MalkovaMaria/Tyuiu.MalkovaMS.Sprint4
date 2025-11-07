using Tyuiu.MalkovaMS.Sprint4.Task2.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод c клавиатуры)                            *");

        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
        Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
        Console.WriteLine("* массива.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.Write("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            numsArray[i] = rnd.Next(2, 9);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.Write(numsArray[i] + " ");
        }
        Console.WriteLine();
        int res = ds.Calculate(numsArray);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма нечетных элементов массива: " + res);
        Console.ReadKey();
    }
}