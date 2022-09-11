using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using System.IO;
using System.Reflection;

namespace SistemaComercioLibrary.Persistence.Context
{
    //responsavel por fazer a conexao com o banco, chama o entity (framework)
    //DataBaseContext : DbContext -> recebe uma herança dbcontext e referente ao ORM
    public class DataBaseContext : DbContext
    {
        string DefaultConnection = "Data Source=DESKTOP-FSJV9IP;Initial Catalog=SistemaComercio;Persist Security Info=True;User ID=sa;Password=julia@2002";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        //    var builder = new ConfigurationBuilder()
        //.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
        //                  .AddJsonFile("appsettings.json");

            //var configuration = builder.Build();

            optionsBuilder.UseSqlServer(DefaultConnection);
        }


        //Atributo referente a tabela no banco de fornecedor
        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Adm> Adm { get; set; }

    }


}
