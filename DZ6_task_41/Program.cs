// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
if(num > 0) 
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

        if (array[i] > 0) count = count + 1;
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
}
else Console.WriteLine("Нужно ввести положительное число");