using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //  Get /HelloWorld/
        public string index()
        {
            return "This is my default action";
        }

        //  Get /HelloWorld/Welcome
        public string Welcome()
        {
            return "This  is the Welcome action needed";
        }
    }
}
