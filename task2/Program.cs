// Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 50);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите индекс строки: ");
int cols = ReadInt("Введите индекс столбца: ");
System.Console.WriteLine();

int[,] numbers = new int[6, 8];
FillMatrix(numbers);
PrintMatrix(numbers);
System.Console.WriteLine();

if (rows < numbers.GetLength(0) && cols < numbers.GetLength(1))
    Console.WriteLine(numbers[rows, cols]);
else
    Console.WriteLine($"{rows}{cols} -> такого числа в массиве нет");
