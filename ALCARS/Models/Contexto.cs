using ALCARS.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace ALCARS.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Carro> carro { get; set; }
        public DbSet<Modelo> modelo { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<ALCARS.Models.CarroAlugado> CarroAlugado { get; set; }
    }

}