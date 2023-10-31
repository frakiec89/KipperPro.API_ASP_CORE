while (true)
{
    Console.WriteLine("Введите логин");
    var log = Console.ReadLine();

    Console.WriteLine("Введите пароль");
    var pass = Console.ReadLine();

    Console.WriteLine("Введите имя");
    var name = Console.ReadLine();

    try
    {
        RegistretionService service = new RegistretionService();

        Console.WriteLine("регистрация :");
        service.AddUser(log, pass , name);
        Console.WriteLine("Успешно");

        Console.WriteLine("авторизация:");
        var us =  service.GetUser(log, pass);
        Console.WriteLine ( "Успешно " + "привет " + us.Name);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

