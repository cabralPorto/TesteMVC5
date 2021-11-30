
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Testes")]
    public class ParametrosController : Controller
    {   
        [Route]
        public ActionResult IndexTeste()
        {
            return View();
        }
  

    }    
        
}