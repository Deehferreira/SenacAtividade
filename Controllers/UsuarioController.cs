using System.Collections.Generic;
using EstudoBC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstudoBC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
            return View();
        }
         [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            ViewBag.Mensagem = "Usuario Cadastrado com sucesso";
            return View();
        }
        public IActionResult Listar()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> Usuarios = ur.Query();
            return View(Usuarios);
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
            return Redirect("Cadastro");
        }
        else
        {
            ViewBag.Mensagem = "Falha no Login";
            return View();
        }
    }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

    }
}