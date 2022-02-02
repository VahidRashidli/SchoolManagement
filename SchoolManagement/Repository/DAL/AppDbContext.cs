using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.DAL
{
   public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options){}
        public DbSet<Student> Students { get; set; }
    }
}
