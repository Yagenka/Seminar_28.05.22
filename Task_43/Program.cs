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


void PointIntersection(int z1, int w1, int z2, int w2)
{
    double temp = w1 - w2;
    if (temp != 0)
    {
        double x = (z2 - z1) / temp;
        double y = w1 * x + z1;
        Console.WriteLine($"Kоординаты точки пересечения для двух прямых ({x};{y})");
        }
    else if (w2 == w1) Console.WriteLine("Прямые параллельны друг другу");
}

PointIntersection(b1, k1, b2, k2);

