// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Антон") {
    Console.WriteLine("Ба, какие люди! Привет, "+username+"!");
}
else {
    Console.Write("Здравствуйте, "+username+"!");
}
