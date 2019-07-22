using DAL.CustomClass;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(): base("SchoolDbContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Add<PKConvention>();
            //modelBuilder.Configurations.Add<SchoolInitializer>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder
            //    .Properties()
            //    .Where(p => p.Name == p.DeclaringType.Name + "_ID")
            //    .Configure(P => P.IsKey());

            //modelBuilder
            //    .Properties()
            //    .Where(p => p.PropertyType.Name == "string")
            //    .Configure(p => p.HasMaxLength(100));

          
            base.OnModelCreating(modelBuilder);
        }
    }
}
