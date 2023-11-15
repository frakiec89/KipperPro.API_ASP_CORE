using KipperPro.ConnsoleClient.ModelApi;
using Newtonsoft.Json;

namespace KipperPro.ConnsoleClient;

internal class RegistretionService
{
  
    internal void AddUser(string? em, string? pass, string? name)
    {

        var us = new UserRequst() { Email = em, Password = pass, Name = name  };
        var jsonUs = JsonConvert.SerializeObject(us);

        ApiService service = new ApiService();
        var jsRespons =  service.AddUser(jsonUs) ;
    }

    internal UserResponse GetUser (string? em, string? pass)
    {
        var us = new UserRequst() { Email = em, Password = pass , Name=string.Empty };
        var jsonUs = JsonConvert.SerializeObject(us);
        ApiService service = new ApiService();
        var jsRespons = service.GetUser(jsonUs);
        return jsRespons;
    }
}