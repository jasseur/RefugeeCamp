using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefugeeCamp.Domaine.Entity;


namespace RefugeeCamp.Data
{

   public class Context : DbContext

    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Refugee> Refugees { get; set; }

        #region HealthCare
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        #endregion HealthCare

        #region Education
        public DbSet<Course> Courses { get; set; }
        public DbSet<Classsroom> Classsrooms { get; set; }
        public DbSet<Level> Levels { get; set; }
        #endregion Education

        #region Warehouse
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<DistributionRecord> DistributionRecords { get; set; }
        #endregion Warehouse

        #region Registration
        public DbSet<Report> Reports { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Family> Familys { get; set; }
        #endregion Registration

        public Context() : base("name = RefugeeCampConection")
        {
            
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
       
        //}
    }
}
