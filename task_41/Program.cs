// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Укажите количество чисел, которое вы хотите ввести: ");
int number = int.Parse(Console.ReadLine());

int[] array = FillArray(number);

Console.WriteLine($"Колличество числел больше 0, которые ввел пользователь, равно {CountNegatives(array)}.");

int[] FillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число и нажмите Enter: ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    return numbers;
}

int CountNegatives(int[] collection)
{
    int count = 0;
    foreach (int item in collection)
    {
        if (item > 0) count ++;
    }
    return count;
}