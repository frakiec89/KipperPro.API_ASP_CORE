using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

internal class ApiService
{
    string host = "http://localhost:5000";

    internal ModelApi.UserResponse GetUser (string jsonUs)
    {
        try
        {
            var url = host + "/api/Registration/authUser";
            string resJson = Post(url, jsonUs);
            
                var us = JsonConvert.DeserializeObject<ModelApi.UserResponse>(resJson);
                return us;
            
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    internal bool AddUser(string jsonUs)
    {
        try
        {
            var  url = host + "/api/Registration/registration";
            string resJson = Post(url, jsonUs);
            return true; 
        }
        catch (Exception ex)
        {
            throw ex ;
        }
    }

    private string Post(string url, string jsContent)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            var content = new StringContent(jsContent, null, "application/json");
            request.Content = content;
            var response =client.Send(request);
           

            switch (response.StatusCode  )
            {
                case HttpStatusCode.BadRequest:  
                var e = response.Content.ReadAsStringAsync().Result;
                 throw new Exception ( e);
                case HttpStatusCode.NotFound:
                    throw new Exception( "Не  верный запрос, проверьте путь  запроса");
                default: return response.Content.ReadAsStringAsync().Result;
            }
        }
        catch (WebException ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public class Error
    {
        public string Message { get; set; } 
    }

}