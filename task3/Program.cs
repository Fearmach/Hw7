// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matr = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 50);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
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


double MatrixEdit(double[,] matrix)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[j, i];
        }
        Console.Write($"{sum / matrix.GetLength(1)} ");
    }
    return sum;
}

System.Console.WriteLine("Введите rows и cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
double[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
System.Console.WriteLine();
MatrixEdit(array2d); //($"{sum / matrix.GetLength(0)} ");
