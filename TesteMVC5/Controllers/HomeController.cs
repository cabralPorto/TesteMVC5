
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {   
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("sobre-nos")]
       public ActionResult About() 
        {
            return View();
        }
        [Route("contato")]
        public ActionResult Contact()
        {
            return View();
        }
        [Route("conteudo")]
        public ContentResult ContentResult()
        {
            return Content("Olá");
        }

        [Route("download/arquivo")]
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/Teste.png"));

            return File(foto, "image/png", "Teste-download.png");
        }
        public HttpUnauthorizedResult HttpUnauthorizedResult() 
        {
            return new HttpUnauthorizedResult();
        
        }
        public JsonResult jsonResult() 
        {
            return Json("Teste:Teste", JsonRequestBehavior.AllowGet);
        }
        public RedirectResult RedirectResult() 
        {
            return new RedirectResult("https://cabralporto.github.io/Site");
        }
        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute(new
            {
                controller = "Teste",
                action = "IndexTeste"
            });
            // return RedirectToAction("IndexTeste","Teste");
        }
               

    }    
        
}