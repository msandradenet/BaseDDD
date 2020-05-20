using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {            
            //string strCon = "Server=DESKTOP-N05LSRE\\SQLEXPRESS;Database=BaseDDD;User Id=dev;Password=123456;";
            string strCon = "Data Source=DESKTOP-N05LSRE\\SQLEXPRESS;Initial Catalog=BaseDDD;Integrated Security=False;User ID=dev;Password=123456;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }

    }
}
