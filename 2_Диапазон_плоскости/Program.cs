/* Программа, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y)*/

int quarter = Input ("Введите номер четверти: ");
int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}

if (quarter == 1)
{
    Console.WriteLine ("Диапазон X (0, Max); Диапазон Y (0, Max)");
}

else if (quarter == 2)
{
    Console.WriteLine ("Диапазон X (Min, 0); Диапазон Y (0, Max)");
}

else if (quarter == 3)
{
    Console.WriteLine ("Диапазон X (Min, 0); Диапазон Y (Min, 0)");
}

else if (quarter == 4)
{
    Console.WriteLine ("Диапазон X (0, Max); Диапазон Y (Min, 0)");
}

else
{
    Console.WriteLine ("Нет такой четверти");
}