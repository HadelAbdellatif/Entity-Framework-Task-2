using Entity_Framework_Task_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Task_2.Data
{
    internal class ApplicationDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=products_task2; Trusted_Connection=true; TrustServerCertificate=true;");
        }
    }
}
