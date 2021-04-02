
using System.Collections.Generic;
using EstudoBC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace EstudoBC.Controllers
{
    public class PacotesController : Controller
    {
        public IActionResult Inserir()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
                return RedirectToAction("Login");
            return View();
        }
        [HttpPost]
        public IActionResult Inserir(Pacotes p)
        {
            PacotesRepository pt = new PacotesRepository();
            pt.Insert(p);
            ViewBag.Mensagem = "Pacote inserido com sucesso";
            return View();
        }
        public IActionResult Listar()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
                return RedirectToAction("Login");
            PacotesRepository pr = new PacotesRepository();
            List<Pacotes> lista =pr.Query();
            return View(lista);
        }
        public IActionResult Editar()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
                return RedirectToAction("Login");
            return View();
        }
        [HttpPost]
        public IActionResult Editar(Pacotes p)
        {
            PacotesRepository pt = new PacotesRepository();
            pt.Editar(p);
            ViewBag.Mensagem = "Pacote atualizado com sucesso";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if(usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                HttpContext.Session.SetInt32("idUsuario", usuario.Id);
                HttpContext.Session.SetString("nomeUsuario", usuario.Nome);
                return View("Login");
            }
            else
            {
            ViewBag.Mensagem = "Falha no Login";
            return View();
            }
        }
        public IActionResult Excluir()
        {   
            if(HttpContext.Session.GetInt32("idUsuario") == null)
                return RedirectToAction("Inserir");
            return View();
        }
        [HttpPost]
        public IActionResult Excluir(Pacotes p)
        {
            PacotesRepository pt = new PacotesRepository();
            pt.Excluir(p);
            ViewBag.Mensagem = "Pacote excluido com sucesso";
            return View();
        }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

}
}