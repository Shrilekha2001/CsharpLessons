using FirstMVCEFApp.Models;
using System;
using Microsoft.EntityFrameworkCore;
using MvcEfApp.Models;
using Microsoft.Identity.Client;
using System.Security.Cryptography.Xml;

namespace FirstMVCEFApp.Models
    
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor>Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appoinment>Appoinments { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilders)
        {
            string conString = @"server= 200411LTP2861\SQLEXPRESS;Database = HospitalDB;integrated security = true;Encrypt = false;";
            optionsBuilders.UseSqlServer(conString);
        }

    }
}
