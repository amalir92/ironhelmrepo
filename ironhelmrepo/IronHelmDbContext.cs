using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class IronHelmDbContext : DbContext
    {
        public IronHelmDbContext() : base(ironhelmrepo.Properties.Settings.Default.dbconnection)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<ProductCatalog> ProductCatalogs { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderLineItem> orderLineItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           // modelBuilder.Entity<Order>().Property(a => a.orderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          //  modelBuilder.Entity<OrderLineItem>().Property(a => a.orderLineItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            /*modelBuilder.Entity<CPerson>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CPerson");
            });

            modelBuilder.Entity<COrganization>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("COrganization");
            });
            */

        }
    }
}
