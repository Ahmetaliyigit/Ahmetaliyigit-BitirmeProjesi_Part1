using Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=AHMETALI\\SQLEXPRESS; Database=E-Ticaret_Projesi_AHMT; Trusted_Connection=True; TrustServerCertificate=True;");
        //}

        public DataContext(DbContextOptions<DataContext> option) : base(option)
        { 

        }
        

        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Product> Products { get; set; }    

        

    }
}
