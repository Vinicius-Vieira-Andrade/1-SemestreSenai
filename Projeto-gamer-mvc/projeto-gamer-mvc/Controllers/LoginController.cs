using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_mvc.Infra;
using projeto_gamer_mvc.Models;

namespace projeto_gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

    	[TempData] //anotation 
        public string Mensagem { get; set; }
        Context c = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName"); //disponibiliza a permissão para quem estiver logado acessa o sistema
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = c.Jogador.FirstOrDefault(j => j.Email == email && j.Senha == senha)!;


            //Lógica da sessão
            if (jogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome!);     //nome da key/chave = username || valor = jogadorBuscado.Nome
                return LocalRedirect("~/");                                          //guarda o jogador na key
                //retorna para a tela home quando não específico dentro ("~/")
            }
            Mensagem = "Dados inválidos, tente novamente!";
            return LocalRedirect("~/Login/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()  //metódo de logout sair do perfil
        {
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}