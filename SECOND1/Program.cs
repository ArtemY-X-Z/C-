Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

if (a/b == b)
{
  Console.WriteLine("Первое число является квадратом второго");  
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
