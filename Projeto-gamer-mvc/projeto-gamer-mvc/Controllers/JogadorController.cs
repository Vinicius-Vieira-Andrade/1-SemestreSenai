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
            Equipe ee = new Equipe();

            novoJogador.Nome = formm["Nome"].ToString();
            novoJogador.Email = formm["Email"].ToString();
            novoJogador.Senha = formm["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(formm["Equipe"]);
            novoJogador.Equipe = c.Equipe.First(e => e.IdEquipe == int.Parse(formm["Equipe"]));


            c.Jogador.Add(novoJogador);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName"); //disponibiliza a permissão para quem estiver logado acessa o sistema
            
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList(); // para acessar a imagem da tabela equipes

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName"); //disponibiliza a permissão para quem estiver logado acessa o sistema

            Jogador joga = c.Jogador.First(joga => joga.IdEquipe == id);

            ViewBag.Jogador = joga;
            ViewBag.Equipe = c.Equipe.ToList(); //instanciar a bag aq na controller para usar a bag na index do jogador

            return View("Editar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdEquipe == id);

            c.Jogador.Remove(j);

            c.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador novoJuegador = new Jogador();

            novoJuegador.IdJogador = int.Parse(form["IdJogador"].ToString());

            novoJuegador.Nome = form["Nome"].ToString();

            novoJuegador.Email = form["Email"].ToString();

            novoJuegador.Senha = form["Senha"].ToString();

            novoJuegador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            Jogador jojo = c.Jogador.First(j => j.IdJogador == j.IdJogador);

            jojo.Nome = novoJuegador.Nome;
            jojo.Email = novoJuegador.Email;
            jojo.Senha = novoJuegador.Senha;
            jojo.IdEquipe = novoJuegador.IdEquipe;

            c.Jogador.Update(jojo);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }
    }
}