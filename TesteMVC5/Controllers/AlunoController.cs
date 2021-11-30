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
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno

            {
                Name = "",
                CPF = "",
                DataMatricula = DateTime.Now,
                Email = "ronaldoemail.com",
                Ativo = false

            };
   
            return RedirectToAction("Index", aluno);
        }
        ActionResult Index(Aluno aluno)
            {
                if (!ModelState.IsValid) return View(aluno);
                
                return View(aluno);
            }
        
    }
}