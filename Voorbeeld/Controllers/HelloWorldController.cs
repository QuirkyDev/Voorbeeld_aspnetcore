using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Voorbeeld.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Dit is de 'index' action method";
        }

        public string Welkom()
        {
            return "Dit is de 'welkom' action method";
        }

        public string Bestelling(int id)
        {
            return "Dit zijn de details van bestelling met id " + id;
        }
    }
}
