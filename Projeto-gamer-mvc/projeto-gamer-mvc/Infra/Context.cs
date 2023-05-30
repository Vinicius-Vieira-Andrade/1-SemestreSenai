using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_gamer_mvc.Models;

namespace projeto_gamer_mvc.Infra
{
    public class Context : DbContext //classe do sistema q fornece autorizacao para trabalhar com o dbcontext, por isso instalar os pacotes do framework
    {
        // pasta que contém a infraestrutura do projeto e a classe é responsavel pelas configuracoes q vao estabelecer a comunicacao com o nosso banco de dados a string
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //se não "!"
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE06-S15; initial catalog = projGamerMVC; User Id=sa; pwd=Senai@134; TrustServerCertificate = true"); //STRING DE CONEXÃO!!!
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}