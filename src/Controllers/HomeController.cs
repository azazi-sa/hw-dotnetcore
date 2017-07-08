using System;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "hello world " + DateTime.Now.ToString();
        }
    }
}