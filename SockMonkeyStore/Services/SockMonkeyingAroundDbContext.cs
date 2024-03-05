using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Services
{
    public class SockMonkeyingAroundDbContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<CustomerAccountModel> CustomerAccounts { get; set; }
        public DbSet<CustomerBillingProfileModel> CustomerBillingProfiles { get; set; }
        public DbSet<CustomerCartItemModel> CustmoerCartItems { get; set; }
        public DbSet<CustomerCartModel> CustomerCarts { get; set; }
        public DbSet<CustomerShippingProfileModel> CustomerShippingProfiles { get; set; }
        public DbSet<OrderInvoiceItemModel> OrderInvoiceItems { get; set; }
        public DbSet<OrdersInvoiceModel> OrderInvoices { get; set; }
        public DbSet<ProductCategoryModel> ProductCategories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
    }
}