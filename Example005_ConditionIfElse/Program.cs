Console.Write("Введите имя пользователя: ");
string? name = Console.ReadLine();

if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура!Это же Маша!");
}

else
{
    Console.Write("Привет,");
    Console.WriteLine(name);
}