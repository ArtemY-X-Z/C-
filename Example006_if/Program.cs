Console.Write("Введитк имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
} 
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}