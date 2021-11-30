
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Testes")]
    public class TesteController : Controller
    {
        [Route ("{id:int}")]
        public ActionResult IndexTeste(int id, string texto)
        {
            return View();
        }
        [Route("{texto:maxlength(50)}/um-outro-teste/{id:int}")]
        public ActionResult IndexTeste2(int id, string texto)
        {
            return View("IndexTeste");
        }

    }
   
}