using AnswerIt.Models;
using AsnwerIt.Models;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnswerIt.Controllers
{
    [Route("api/[controller]")]
    public class QasController : Controller
    {
        [HttpGet]
        public IEnumerable Get()
        {
            var virtualPath = "data/qas.json";
            var env = new HostingEnvironment();

            if (string.IsNullOrWhiteSpace(env.WebRootPath))
            {
                env.WebRootPath = Directory.GetCurrentDirectory();
            }
            
            var filePath = env.WebRootPath + "\\wwwroot\\"+ virtualPath;

            var json = System.IO.File.ReadAllText(filePath);
            var qas = JsonConvert.DeserializeObject<IEnumerable<object>>(json);       

            return qas;
        }
    }
}