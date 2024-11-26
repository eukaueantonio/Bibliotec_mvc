using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{
    //classe que terá as informações do banco de dados 
    public class Context : DbContext
    {
        //criar um método contrutor
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        //OnConfiguring -> Possui a configuracao da conexao com o banco de dados 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //colocar as informacoes do banco de dados

            //as configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"
                 Data Source=DESKTOP-FL7LTBT\SQLEXPRESS02; 
                 Initial Catalog = Bibliotec_mvc;
                 User Id=sa; 
                 Password=123; 
                 Integrated Security=true; 
                 TrustServerCertificate = true");
            }
        }

        //As tabelas do banco de dados
        public DbSet<Categoria> Categoria{get; set;}
        public DbSet<Curso> Curso{get; set;}
        public DbSet<Livro> Livro{get; set;}
        public DbSet<LivroCategoria> LivroCategoria{get; set;}
        public DbSet<LivroReserva> LivroReserva{get; set;}

    }

}
