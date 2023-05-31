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


        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form) //recebe como parametro os dados informados no formulario do frontend
        {
            Equipe novaEquipe = new Equipe(); //cadastra nova equipe 

            novaEquipe.Nome = form["Nome"].ToString(); //recebe o nome do formulario para aplicar ao novo objeto equipe



            //logica do sistema de upload de imagem
            if (form.Files.Count > 0) //se existe um arquivo selecionado
            {
                var file = form.Files[0]; //guarda a imagem a partir da posicao 0 que foi enviada no formulario

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes"); //variavel que guarda a logica do caminho que guardará as imagens upadas, cria a pasta equipes q terá as imagens

                if (!Directory.Exists(folder)) //se o diretorio n existir, crie-o
                {
                    Directory.CreateDirectory(folder); //cria o diretorio
                }

                var path = Path.Combine(folder, file.FileName); //combina a pasta com o nome do arquivo da imagem

                using (var stream = new FileStream(path, FileMode.Create)) //executa o serviço e quando feito finaliza, isso é o "using"
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }

            else
            {
                novaEquipe.Imagem = "padrao.png";
            }



            //vem como string, precisamos q venha como imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();          //recebe o imagem do formulario para aplicar ao novo objeto equipe



            caminho.Equipe.Add(novaEquipe); //adiciona pelo context esse novo objeto
            caminho.SaveChanges(); //salva as mudanças feitas

            return LocalRedirect("~/Equipe/Listar"); //retorna a rota
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}