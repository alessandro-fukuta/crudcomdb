using Microsoft.EntityFrameworkCore;
using crudcomdb.Models;

namespace crudcomdb.Data {
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // aqui vamos inserir as classes que representam nossas tabelas no banco de dados
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        
	
    }

}
