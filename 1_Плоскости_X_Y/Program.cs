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
if (x > 0 && y > 0)
{
    Console.WriteLine ("1 четверть");
}

if (x < 0 && y > 0)
{
    Console.WriteLine ("2 четверть");
}

if (x < 0 && y < 0)
{
    Console.WriteLine ("3 четверть");
}

if (x > 0 && y < 0)
{
    Console.WriteLine ("4 четверть");
}