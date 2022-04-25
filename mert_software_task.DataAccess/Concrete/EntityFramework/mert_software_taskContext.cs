using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.DataAccess.Concrete.EntityFramework
{
    public class mert_software_taskContext : DbContext
    {
        public DbSet<AddressOfEmployee> AddressOfEmployess { get; set; }
        public DbSet<AddressOfSupplier> AddressOfSuppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailOfOrder> DetailsOfOrders { get; set; }
        public DbSet<Employee> Employess { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShipAddressOfOrder> ShipAddressOfOrders { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TerritoryIdOfEmployee> TerritoryIdsOfEmployess { get; set; }
        public DbSet<AddressOfCustomer> AddressOfCustomers { get; set; }
    }
}
