Console.Clear();

int ReadIntFromConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountNumbers(int num)
{
    int count = 0;
    int currentNum = num;

    while (currentNum > 0)
    {
        count++;
        currentNum /= 10;
    }
    return count;
}

int GetFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

void FillIntArray(int[] array, int minValue = 0, int maxValue = 100)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintIntArray(int[] array)
{
    Console.Write($"Вывод массива: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");
}

// Task02();
// 2)Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void Task02()
{
    int number = ReadIntFromConsole("Введите число: ");
    int count = GetCountNumbers(number);
    Console.WriteLine($"Количество цифр в числе {number} -> {count}");
}

// Task03();
// 3)Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

void Task03()
{
    int number = ReadIntFromConsole("Введите число: ");
    int factorial = GetFactorial(number);
    Console.WriteLine($"Факториал числа {number} -> {factorial}");
}

Task04();
// 4)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Task04()
{
    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] massiv = new int[size];

    FillIntArray(massiv, 0, 2);
    PrintIntArray(massiv);
}


