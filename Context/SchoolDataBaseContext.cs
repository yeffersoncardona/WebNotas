using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebNotas.Models;

namespace WebNotas.Context
{
    public class SchoolDataBaseContext:DbContext
    {
        public SchoolDataBaseContext(DbContextOptions<SchoolDataBaseContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
