using Tyuiu.MalkovaMS.Sprint4.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод c клавиатуры)                            *");

        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9. Подсчитать произведение  *");
        Console.WriteLine("* четных элементов массива.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int len;
        Console.Write("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());


        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine("Сумма четных элементов массива: " + res);
        Console.ReadKey();
    }
}