// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях
//  (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min,int max)
{ 
    int[] array = new int[size]; 
    Random rnd= new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)

{ 
     Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
       if (i<array.Length-1)Console.Write($"{array[i]},");
       else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int GetSumEven(int[] array)
{
    int sumEven = 0;
    for (int i=0; i<array.Length; i++ )
    {
        if(i%2 != 0) sumEven +=array[i]; 
    }
    return sumEven;
}

int[] arr = CreateArrayRndInt(6, -10, 10); 
PrintArray(arr);
int sumEven= GetSumEven(arr);
Console.WriteLine($"сумма чисел стоящих нeчетных позициях в массиве = {sumEven}"); 


