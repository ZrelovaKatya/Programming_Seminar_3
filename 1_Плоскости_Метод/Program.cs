/* Программа, которая принимает на вход кооринаты точки X и Y, 
причем X и Y не равно нулю и выдает номер четверти плоскости, в которой находится эта точка*/

int x = Input ("Введите координату x: ");
int y = Input ("Введите координату y: ");
int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}

if (x == 0 || y == 0)
{
    Console.WriteLine ("x и y не могут быть равны нулю");
    return;
}

int result = GetNumberQuarter (x, y);
Console.WriteLine ($"{result} четверть");

int GetNumberQuarter (int x, int y)
{
    int result =0;
    if (x > 0 && y > 0)
    {
        result = 1;
    }
    if (x < 0 && y > 0)
    {
        result = 2;
    }
    if (x < 0 && y < 0)
    {
        result = 3;
    }
    if (x > 0 && y < 0)
    {
        result = 4;
    }
    return result;
}