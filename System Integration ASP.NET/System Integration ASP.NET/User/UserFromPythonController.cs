using Microsoft.AspNetCore.Mvc;

namespace System_Integration_ASP.NET.User;



[Route("UserFromPython")]
public class UserFromPythonController {

    [Route("Json")]
    [HttpGet]
    public async Task<object?> GetJsonUser()
    {
        var client = new HttpClient();

        return await client.GetFromJsonAsync<UserListModel>("http://127.0.0.1:5000/json");

    }
    
    [Route("Csv")]
    [HttpGet]
    public async Task<object?> GetCsvUser()
    {
        var client = new HttpClient();

        return await client.GetFromJsonAsync<UserListModel>("http://127.0.0.1:5000/csv");

    }
    
    [Route("Xml")]
    [HttpGet]
    public async Task<object?> GetXmlUser()
    {
        var client = new HttpClient();

        return await client.GetFromJsonAsync<UserListModel>("http://127.0.0.1:5000/xml");

    }
    
    [Route("Yaml")]
    [HttpGet]
    public async Task<object?> GetYamlUser()
    {
        var client = new HttpClient();

        return await client.GetFromJsonAsync<UserListModel>("http://127.0.0.1:5000/yaml");

    }
    
    [Route("Txt")]
    [HttpGet]
    public async Task<object?> GetTxtUser()
    {
        var client = new HttpClient();

        return await client.GetFromJsonAsync<UserListModel>("http://127.0.0.1:5000/txt");

    }


}