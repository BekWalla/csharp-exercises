using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            string html = "<form method='post'>" +
               "<input type='text' name='name' />" +
               "<select id='language' runat=server>" +
               "<option value='English'>English</option>" +
               "<option value='French'>Francais</option>" +
               "<option value='German'>Deutsch</option>" +
               "<option value='Spanish'>Espanol</option>" +
               "<option value='Italian'>Italiano</option>" +
               "<input type='submit' value='Greet me!' action=Redirect'/CreateMessage'/>" +
               "</form>";
            string language = language.Value.ToString();
            {
                return Content(html, "text/html");
            }

        }
    }
    // /Hello
    [Route("/Hello")]
    [HttpPost]
    public IActionResult Display(string name = "World")
    {
        if (txtlanguage.Value = )
        return Content($"<h1>Hello {name} </h1>", "text/html");
    }

    [Route("/Hello/{name}")]
    public IActionResult Index2(string name)
    {
        return Content($"<h1>Hello {name} </h1>", "text/html");
    }



    public IActionResult Goodbye()
    {
        return Content("Goodbye");
    }
}
}
