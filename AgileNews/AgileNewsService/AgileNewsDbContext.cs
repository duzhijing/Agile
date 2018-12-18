using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsService
{
    using AgileNewsEntity;
    using System.Data.Entity;
   public class AgileNewsDbContext:DbContext
    {
        public AgileNewsDbContext():base("name=connString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AdminPerson> AdminPersons { get; set; }
        public DbSet<Comments> AdminRoles { get; set; }





    }
}
