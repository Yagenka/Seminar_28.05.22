// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

Console.WriteLine("Введите значение b1");
int b1 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите значение k1");
int k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2");
int b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2");
int k2 = int.Parse(Console.ReadLine());


void PointIntersection(int b11, int k11, int b22, int k22)
{
    double temp = k11 - k22;
    if (temp != 0)
    {
        double x = (b22 - b11) / temp;
        double y = k11 * x + b11;
        Console.WriteLine($"координаты точки пересечения для двух прямых ({x};{y})");
        }
    else if (k22 == k11) Console.WriteLine("Прямые параллельны друг другу");
}

PointIntersection(b1, k1, b2, k2);

