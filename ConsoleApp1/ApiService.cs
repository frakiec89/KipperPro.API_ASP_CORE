using System.Net;

internal class ApiService
{
    internal bool AddUser(string jsonUs)
    {
        string host = "http://localhost:5000";

        try
        {
            var  url = host + "/api/Registration/registration";
            string resJson = Post(url, jsonUs);
            return true; 

        }
        catch (Exception ex)
        {

            throw;
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
            response.EnsureSuccessStatusCode();

            if(response.StatusCode!= System.Net.HttpStatusCode.OK)
            {
                var e =  response.Content;
            }
            return  response.Content.ReadAsStringAsync().Result;
        }
        catch (WebException ex)
        {
            throw new Exception(ex.Message);
        }
    }
}