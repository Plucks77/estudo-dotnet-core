using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Database
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options): base(options)
        { }

      
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Artigo> Artigo { get; set; }

        
    }
}
