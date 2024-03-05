using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Services
{
    public class SockMonkeyingAroundDbContext : DbContext
    {
        public SockMonkeyingAroundDbContext()
           : base("name=SockMonkeyingAroundDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CustomerBillingProfile> CustomerBillingProfiles { get; set; }
        public virtual DbSet<CustomerCart> CustomerCarts { get; set; }
        public virtual DbSet<CustomerCartItem> CustomerCartItems { get; set; }
        public virtual DbSet<CustomerShippingProfile> CustomerShippingProfiles { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<OrderInvoice> OrderInvoices { get; set; }
        public virtual DbSet<OrderInvoiceItem> OrderInvoiceItems { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories{ get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
