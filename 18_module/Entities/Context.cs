using _18_module.Factory_Method.Abonement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Entities
{
    internal class Context : DbContext
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=18Module;Integrated Security=True";

        public Context()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        #region Таблицы

        public DbSet<Client> Clients { get; set; }

        #endregion
    }
}
