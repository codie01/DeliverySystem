using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DeliveryServiceManagementSystem.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool scheduled { get; set; }
    }

    
    public partial class AppDBContext:DbContext
    {
        public DbSet<Driver> drivers { get; set; }
    }
}