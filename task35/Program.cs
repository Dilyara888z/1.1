// Задача 35. Задайте одномерный массив из 123 случайных чисел. 
// найдите количество элементов массива, значения которых лежат отрезке [10,99]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[]  randomArray= CreateArrayRndInt(123, 0, 1000);
int Count(int[] randomArray)
{ 
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if(randomArray[i]>=10 && randomArray[i]<100)
        count++;
    }
    return count;
}
PrintArray(randomArray);
Console.Write(Count(randomArray));