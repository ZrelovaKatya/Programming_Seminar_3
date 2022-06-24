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
int distanceX = CalculateDistance (x1, x2);
int distanceY = CalculateDistance (y1, y2);

int CalculateDistance (int a, int b)
{
    return a - b;
}

int Quadro (int a)
{
    return a * a;
}

double result = Math.Sqrt (Quadro (distanceX) + Quadro (distanceY));
Console.WriteLine ("Расстояние между точками " + result);
