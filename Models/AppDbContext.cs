﻿using Microsoft.EntityFrameworkCore;

namespace mf_api_fuel_manager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {                
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo>  Consumos { get; set; }   
    }
}
