

Console.WriteLine("Введите логин");
var log  = Console.ReadLine();

Console.WriteLine("Введите пароль");
var pass = Console.ReadLine();

Console.WriteLine("Введите имя");
var name = Console.ReadLine();

try
{
    RegistretionService  service = new RegistretionService();
    service.AddUser(log, pass, name);
}
catch (Exception ex)
{
  Console.WriteLine(ex.ToString()); 
}