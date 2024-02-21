using System.Collections;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

[Route("UserFromPython")]
public class UserFromPythonController {

    [Route("Json")]
    [HttpGet]
    
    public Task<object> GetJsonUser()
    {
        

        return Task.FromResult<object>(Ok(users));
    }


}