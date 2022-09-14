// Напишите программу замена элементов массива: 
// положительные элементы заменит на соответствующие 
// отрицательные, и наоборот.
// [-4,-8,8,2]->[4,8,-8,2]


int[] CreateArrayRndInt(int size, int min, int max)
//метод создания необходимого массива
{ 
    int[] array = new int[size]; 
    Random rnd= new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}
//создание метода для вывода в косоль (вывода массива)
void PrintArray(int[] array) // int[] array это массив, который мы вывели выше
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
void ChangeNegPossElem(int [] array)
{
for (int i = 0; i < array.Length; i++) 
  array[i] *=-1;
}

int[] arr = CreateArrayRndInt(4, -99, 99); //создаем переменную соответствующего типа
PrintArray(arr);
ChangeNegPossElem(arr);
PrintArray(arr);
