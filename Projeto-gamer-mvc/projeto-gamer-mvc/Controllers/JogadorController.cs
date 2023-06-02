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
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context(); // instancia o context pra trabahar com o banco de dados

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formm, Equipe e)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = formm["Nome"].ToString();
            novoJogador.Email = formm["Email"].ToString();
            novoJogador.Senha = formm["Senha"].ToString();

            c.Jogador.Add(novoJogador);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList(); // para acessar a imagem da tabela equipes

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}