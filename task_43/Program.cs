// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите первое число уравнения первой прямой: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число уравнения первой прямой: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите первое число уравнения второй прямой: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число уравнения второй прямой: ");
double b2 = double.Parse(Console.ReadLine());

while (true)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают.");
        break;
    }
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны.");
        break;
    }
    else
    {
        double[] array = CrossPoint(k1, b1, k2, b2);
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({array[0]}; {array[1]}).");
        break;
    }
}

double[] CrossPoint(double a1, double s1, double a2, double s2)
{
    double[] CrossPointArray = new double[2];
    CrossPointArray[0] = (s2 - s1) / (a1 - a2);
    CrossPointArray[1] = a1 * CrossPointArray[0] + s1;
    return CrossPointArray;
}
