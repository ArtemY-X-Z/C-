int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Опредилить кратное число и остаток от деления .");
    Console.WriteLine("2.Првое число евляется ли квадратом второго .");
    Console.WriteLine("3. .");
    Console.WriteLine("4. .");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
           int numberRequest(string massage)
           {
             Console.WriteLine(massage);
             int namber = Convert.ToInt32(Console.ReadLine());
             return namber;
           }

           int numberOne = numberRequest("Введите первое число: ");
           int numberTwo = numberRequest("Введите второе число: ");

           if (numberOne % numberTwo == 0)
           {
             Console.WriteLine("Число кратно!");
           }
           else
           Console.WriteLine($"Не кратно - остаток от деления {numberOne % numberTwo}");
           
           break;
        
        case 2 :
           
           int number1 = numberRequest("Введите первое число: ");
           int number2 = numberRequest("Введите второе число: ");

           if (number1 * number1 == number2 || number2 * number2 == number1 )
           {
             Console.WriteLine("Число кратно!");
           }
           else
           Console.WriteLine($"Не кратно - остаток от деления {number1 % number2}");
           
           break;
        

    
        

         

        default:
        begin = false;
        break;
    }    
}

