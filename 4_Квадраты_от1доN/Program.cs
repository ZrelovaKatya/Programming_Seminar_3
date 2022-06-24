/* Программа, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N */
Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
   int result = Quadro (count);
   Console.Write($"{result}, ");
   count++;
}

Console.WriteLine (Quadro(n));

int Quadro (int a)
{
    return a * a;
}