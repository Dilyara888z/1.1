// 1.Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9,9]. 
//2. Найдите сумму отрицательных и  положительных элементов массива.
// 3/ выводд результата
//Например, в массиве [3,9-8,1,0,-7,2,-1,8-3-1,6] 
//сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min,int max)
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
// создаем методдля поиска суммы положительнвх и отрицательныхчисел
int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i=0; i<array.Length; i++ )
    {
        if(array[i]<0) sumNeg +=array[i]; // += - это суммируем жлемент в переменную
        else sumPos += array [i];
    }
    int [] result = new int[2];
    result[0] = sumNeg;
    result[1] = sumPos;
    return result;
       // return new int []{sumNeg, sumPos}; сокращение строк 43-45
}
//создаем переменную соответствующего типа
int[] arr = CreateArrayRndInt(12, -9, 9); //создаем переменную соответствующего типа
PrintArray(arr);
int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"сумма отрицательных чисел = {sumPosNegElem[0]}"); // [0] потому что в методе 32-43 стр искали сначала отрицательные элементы
Console.WriteLine($"сумма положительных чисел = {sumPosNegElem[1]}"); // [1] потому что в методе 32-43 стр положительные элементы искали во вторую очередь