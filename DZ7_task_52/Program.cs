// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{    
    int[,] matrix = new int[row,col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] newMatrix = CreateMatrixRndInt(3, 3, 0, 9);

PrintMatrix(newMatrix);

void PrintArithmeticMean(int[,] ar)
{
    double summ = 0;
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            summ = summ + ar[j, i];
        }
        double num = summ / ar.GetLength(1);

        Console.Write($"{Math.Round(num, 1)}  ");
        summ = 0;
    }
}
PrintArithmeticMean(newMatrix);