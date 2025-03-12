using Microsoft.EntityFrameworkCore;
using PizzeriaSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Infraestructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Produtos { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estoque.db");
            Console.WriteLine($"Banco de dados em: {path}");
            options.UseSqlite($"Data Source={path}");
        }

    }
}
