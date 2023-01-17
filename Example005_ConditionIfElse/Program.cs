Console.Write("Введите имя пользователя на англ.языке: ");
string? name = Console.ReadLine();

if (name.ToLower() == "masha")
{
    Console.WriteLine("Ура!Это же Маша!");
}

else
{
    Console.Write("Привет,");
    Console.WriteLine(name);
}