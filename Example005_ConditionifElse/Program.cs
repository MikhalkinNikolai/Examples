Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "nikolai")
{
    Console.WriteLine("Ура, это же Колян!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}