using System.Net;
using System.Net.Http.Json;

internal class ApiService
{
    internal bool AddUser(string jsonUs)
    {
        string host = "http://localhost:5000";

        try
        {
            var  url = host + "/api/Registration/registration";
            string resJson = Post(url, jsonUs);
            if (resJson != "true")
            {
                throw new Exception(resJson);
            }
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
           

            if(response.StatusCode == HttpStatusCode.BadRequest  )
            {
                var e = response.Content.ReadAsStringAsync().Result;
                return e;
            }
          
            return  response.Content.ReadAsStringAsync().Result;
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