using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DeliveryServiceManagementSystem.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int distance { get; set; }
        public int driverId { get; set; }
        public bool deliverd { get; set; }
    }

    public partial class AppDBContext : DbContext
    {
        public DbSet<Route> routes { get; set; }
    }
}