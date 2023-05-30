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
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        Context caminho = new Context(); //instancia um objeto da classe context para poder utilizar o banco de dados

        [Route("Listar")] //http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            //mochila que guarda a lista das equipes, podemos usar essa "mochila" na view de equipe

            ViewBag.Equipe = caminho.Equipe.ToList(); //listar as equipes dentro da tabela EQUIPE

            //retorna a view de equipe
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form) //recebe como parametro os dados informados no formulario do frontend
        {
            Equipe novaEquipe = new Equipe(); //cadastra nova equipe 

            novaEquipe.Nome = form["Nome"].ToString(); //recebe o nome do formulario para aplicar ao novo objeto equipe
            novaEquipe.Imagem = form["Imagem"].ToString(); //recebe o imagem do formulario para aplicar ao novo objeto equipe

            caminho.Add(novaEquipe); //adiciona pelo contexto esse novo objeto
            caminho.SaveChanges(); //salva as mudanças feitas

            ViewBag.Equipe = caminho.Equipe.ToList(); //lista novamente

            return LocalRedirect("~/Equipe/Listar"); //retorna a rota
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}