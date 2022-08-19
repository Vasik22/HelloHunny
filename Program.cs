Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "вероника")
{
    Console.WriteLine("Ура, ура, наконец-то!");
}
else
{
    Console.WriteLine("Привет,!");
    Console.WriteLine(username);

}
Console.Write("This is the end");