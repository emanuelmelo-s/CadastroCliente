using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Data
{
    public class AppDbContext : DbContext
    {
        // primeiro passo para subir o banco é criar a pasta Data com a classe AppDbContext
        // segundo passo adicionar os pacotes do entity e colocar a herança na classe que estamos (AppDbContext : DbContext)
        // a classe Dbcontext serve para a AppDbContext herdar tudo para ela
        //terceiro passo configurar a public DbSet<Cliente> Clientes { get; set; }
        //quarto passo adicionar as configurações do statup 
        // No método ConfigureServices, comando services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CadastroClientesDbContext")));
        //quinto passo configurar a conectioString no appsetting.json
            //Trusted Connection é o tipo de conexão = Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            //para conseguir a conection do sql só ir em propriedades do SQL e copiar o nome do banco
        //sexto rodar o add-migration para subir o banco e após concluir, rodar o update Database

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        //no caso essa serve para a classe receber essa base configurações da (DbContextOptions<AppDbContext>)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
