using Microsoft.EntityFrameworkCore;
using MvcIntroduction.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcIntroduction.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }

    }
}
