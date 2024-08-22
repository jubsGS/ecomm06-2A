using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm06_2A.Models
{
    public class Contexto :DbContext
    {
        public DbSet<Usuario> Usuario {  get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Compra> Compra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseNpgsql("Host:pgsql.projetoscti.com.br; Database: projetoscti6; Username: projetoscti6; Password: eq52A268")
        }
    }
}
