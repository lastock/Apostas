using Apostas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Apostas.Infra.Data.Context
{
    public class ContextBase : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }


        public ContextBase(DbContextOptions<ContextBase> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Apostador> Apostadores { get; set;}
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(RetornaUrlConection());
            }
        }

        public string RetornaUrlConection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());

            Configuration = builder.Build();
            string conexao = Configuration.GetConnectionString("ApostasConnection");
            return conexao;
        }
    }
}
