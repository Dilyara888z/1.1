// Задайте массив.
//  Напишите программу, которая определяет, присутствует ли 
//  заданное число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

bool FindNum(int[] array, int num)
{
    bool j = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) j = true;
    }
    return j;
}
Console.Write("ввеедите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(5, 0, 1000);
PrintArray(arr);
bool a = FindNum(arr, num);
Console.WriteLine(a?"да":"нет"); // Console.WriteLine(a == true?"да":"нет"); если: !a? то наоборот
// if (a) Console.WriteLine("да");
// else Console.WriteLine("нет");
