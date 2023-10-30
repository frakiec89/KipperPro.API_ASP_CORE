using ModelApi;
using Newtonsoft.Json;

internal class RegistretionService
{
  
    internal void AddUser(string? log, string? pass, string? name)
    {

        var us = new UserRequst() { Login = log, Password = pass, Name = name };
        var jsonUs = JsonConvert.SerializeObject(us);

        ApiService service = new ApiService();
        var jsRespons =  service.AddUser(jsonUs) ;


    }
}