using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class ContatosController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new DataContext())
            {
                var contatos = ctx.Contatos.OrderBy(x => x.Nome).ToList();

                return View(contatos);
            }
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Contato contato)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "O modelo de dados não é válido");
                return View(contato);
            }

            using (var ctx = new DataContext())
            {
                ctx.Contatos.Add(contato);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int? id)
        {
            return ViewContatos("Editar", id);
        }

        private ActionResult ViewContatos(string viewName, int? id)
        {
            if (id == null)
                return HttpNotFound();

            using (var ctx = new DataContext())
            {
                var contato = ctx.Contatos.Find(id);

                if (contato == null)
                    return HttpNotFound();

                return View(viewName, contato);
            }
        }

        [HttpPost]
        public ActionResult Editar(Contato contato)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "O modelo de dados não é válido");
                return View(contato);
            }

            using (var ctx = new DataContext())
            {
                ctx.Contatos.Attach(contato);
                ctx.Entry(contato).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Remover(int? id)
        {
            return ViewContatos("Remover", id);
        }

        [HttpPost]
        public ActionResult Remover(int id)
        {
            using (var ctx = new DataContext())
            {
                var contato = ctx.Contatos.Find(id);
                ctx.Contatos.Remove(contato);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Detalhar(int? id)
        {
            return ViewContatos("Detalhar", id);
        }
    }
}