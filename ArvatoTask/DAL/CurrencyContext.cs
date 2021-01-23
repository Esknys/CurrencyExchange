using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ArvatoTask.DAL
{
    public class Currencies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double RateEuro { get; set; }
        public string Date { get; set; }
    }
        public class CurrencyContext : DbContext
        {

        public CurrencyContext(DbContextOptions<CurrencyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Currencies> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        }
    }

