using Microsoft.EntityFrameworkCore;
using Studentmana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.DBContexts
{
   
        public class SchoolDBContext : DbContext
        {
              public SchoolDBContext(DbContextOptions options) : base(options)
              {

              }
              public DbSet<Grade> grades { get; set; }
              public DbSet<Student> students { get; set; }
              protected override void OnModelCreating(ModelBuilder modelBuilder)
              {
                    base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grade>().HasData(
             new
             {
                 GradeId = 1,
                 GradeName = "lopabc",
                 IsDeleted = true
             },
             new
             {
                 GradeId = 2,
                 GradeName = "lopabc2",
                 IsDeleted = true
             },
             new
             {
                 GradeId = 3,
                 GradeName = "lopabc3",
                 IsDeleted = true
             },
             new
             {
                 GradeId = 4,
                 GradeName = "lopabc4",
                 IsDeleted = true
             }
         );
        }

        }
}

