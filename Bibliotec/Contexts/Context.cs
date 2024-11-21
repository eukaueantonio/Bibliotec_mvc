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
                //Data Source => nome do banco de dados
                //Initial Catalog => nome do banco de dados
                //Integrated Security => usar o windows para autenticar
                //User Id => usuario do banco de dados
                //Password => senha do banco de dados
                
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
        public DbSet<Categoria> {get ;set;}
        public DbSet<Curso> {get ;set;}
        public DbSet<Livro> { get; set; }
        public DbSet<Usuario> { get; set; }
        public DbSet<LivroCategoria> { get; set; }
        public DbSet<LivroReserva> { get; set; }

    }

}
