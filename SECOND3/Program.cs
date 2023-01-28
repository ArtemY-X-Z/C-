Console.WriteLine("Введите число :");

int number = Math.Abs(int.Parse(Console.ReadLine()));

for (int i = -number; i <= number; i++)
{
    Console.Write($"{i} ");//интерполяция
}