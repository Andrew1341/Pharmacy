using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore.Extensions;
using System.Data.Entity;
using Pharmacy.Model;

namespace Pharmacy
{
    public class PharmContext : DbContext
    {
        public DbSet<Cities> City { get; set; }
        public DbSet<Regions> Region { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Suppliers> Supplier { get; set; }

        public bool IsEmpty()
        {
            try
            {
                return City.Count() == 0 && Region.Count() == 0 && Employee.Count() == 0 && Supplier.Count() == 0;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
