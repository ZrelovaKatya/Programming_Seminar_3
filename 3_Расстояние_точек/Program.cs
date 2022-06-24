/* Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
А (3, 6); В (2,1) -> 5,09 */
int x1 = Input ("Введите координаты точки x1: ");
int y1 = Input ("Введите координаты точки y1: ");
int x2 = Input ("Введите координаты точки x2: ");
int y2 = Input ("Введите координаты точки y2: ");
int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}

double result = Math.Sqrt ((x2 - x1)*(x2-x1) + (y2 - y1)*(y2-y1));
Console.WriteLine (result);
