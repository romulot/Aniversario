using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tp3_Romulo.Models;

namespace Tp3_Romulo.Controllers
{
    public class PessoaController : Controller
    {
        static List<PessoaModel> lst_Pessoa;

        // GET: Pessoa
        public ActionResult Index()
        {

            if (lst_Pessoa == null) { lst_Pessoa = new List<PessoaModel>(); }
            //PessoaModel aux = new PessoaModel();
            //aux.nome = "Romulo";
            //aux.cpf = "11111111110";
            //aux.nascimento = new DateTime(1989, 11, 24);

            return View(lst_Pessoa);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel _pessoa)
        {
            try
            {
                lst_Pessoa.Add(_pessoa);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
