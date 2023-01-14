// Напишите программу, которая найдет точку пересечения двух
// прямых, заданных уровнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double DataEnter(string str)
{
    Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

void IntersectionPoint(double k, double b)
{
    // y = k1 * x + b1
    // y = k2 * x + b2

    // 0 = (k2 * x + b2) - (k1 * x + b1)
    // y = k1 * x + b1

    // 0 = k2 * x + b2 - k1 * x - b1
    // y = k1 * x + b1

    // 0 = k2 * x - k1 * x + b2 - b1
    // y = k1 * x + b1

    // k1 * x - k2 * x = b2 - b1
    // y = k1 * x + b1

    // (k1 - k2) * x = b2 - b1
    // y = k1 * x + b1

    // x = (b2 - b1)  / (k1 - k2)
    // y = k1 * x + b1

    double x = (b * 2 - b * 1)  / (k * 1 - k * 2);
    double y = k * 1 * x + b * 1;
    Console.Write("координаты точки пересечения " + x + "; " + y);
}

double k = DataEnter("Введите значение k ");
double b = DataEnter("Введите значение b ");

IntersectionPoint(k, b);