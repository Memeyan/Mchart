using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3Intento1.Pages.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Answers> Answers { get; set; }
        public DbSet<Escuelas> Escuelas { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<TblUsers> TblUsers { get; set; }


    }
}
