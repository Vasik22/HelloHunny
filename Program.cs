Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Вероника")
{
    Console.WriteLine("Ура, ура, наконец-то!");
}
else
{
    Console.WriteLine("Привет,!");
    Console.WriteLine(username);

}
