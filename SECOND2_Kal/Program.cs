Console.WriteLine("Введите число от 1 до 7: ");
string dayOfWeeks = Console.ReadLine();

if (dayOfWeeks == "1")
{
    Console.WriteLine("Сегодня понедельник! ");
}
else if (dayOfWeeks == "2")
{
    Console.WriteLine("Сегодня Вторник! ");
}
else if (dayOfWeeks == "3")
{
    Console.WriteLine("Сегодня Среда ! ");
}
else if (dayOfWeeks == "4")
{
    Console.WriteLine("Сегодня Четверг! ");
}
else if (dayOfWeeks == "5")
{
    Console.WriteLine("Сегодня ПЯТНИЦА ! ");
}
else if (dayOfWeeks == "6")
{
    Console.WriteLine("Сегодня Суббота! ");
}
else if (dayOfWeeks == "7")
{
    Console.WriteLine("Сегодня Воскресенье! ");
}
else 
{
    Console.WriteLine("Вы ввели не верное число ! ");
}