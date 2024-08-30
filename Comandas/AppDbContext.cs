using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    //Clase que representa o banco de dados
    public class AppDbContext : DbContext
    {
         //priedade que representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }

        //métodos que configura iformando o EF que o banco será SQLite 
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }
}
