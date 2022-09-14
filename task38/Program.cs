// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
//  элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRnd(int size, int min, int max) 
{    
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i = i + 1) // i = i - 1   ....  i -= 2 ..... i--
    {
        array[i] = rnd.NextDouble() + rnd.Next(min, max);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
} 

void PrintArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
double[] arr = CreateArrayRnd(10, 1, 10);
PrintArray(arr);

double SumMinMax(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxNum < array[i]) maxNum = array[i];
        if (minNum > array[i]) minNum = array[i];
    }
    double diff = maxNum - minNum;
    return diff;
}
Console.Write($"-> {Math.Round(SumMinMax(arr), 2)}");