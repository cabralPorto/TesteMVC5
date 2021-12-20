﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    
    
    
    public class AlunoController : Controller
    {   
        [HttpGet]
        [Route("novo-aluno")]
       
        public ActionResult NovoAluno()
        {       
                return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
       [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)

        {
            if (!ModelState.IsValid) return View(aluno);

            //Regra de N
            return View(aluno);
        }
        
    }
}