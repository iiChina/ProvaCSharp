using Microsoft.EntityFrameworkCore;
using ProvaCSharp.Models;

namespace ProvaCSharp.Data
{
    public class ProvaDbContext : DbContext
    {
        public ProvaDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
