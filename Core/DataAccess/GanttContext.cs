using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Core.DataAccess
{
    public class GanttContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=BILTAY-SERVER\\MSSQLSERVER4;Database=Gantt;Trusted_Connection=true");
        //}
        //public GanttContext():base("Gannt")
        //{

        //}

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Dependency> Dependencies { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceAssignment> ResourceAssignments { get; set; }
    }
}