Console.WriteLine("Введи число");
string numberStr = Console.ReadLine();  // Всегда будет строкаs
int number = Convert.ToInt32(numberStr);  //Из строчки получается число

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");