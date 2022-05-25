using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<project.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<project.Models.Bill> Bill { get; set; }

        public DbSet<project.Models.BillType> BillType { get; set; }

        public DbSet<project.Models.Branch> Branch { get; set; }

        public DbSet<project.Models.CashBank> CashBank { get; set; }

        public DbSet<project.Models.Currency> Currency { get; set; }

        public DbSet<project.Models.Customer> Customer { get; set; }

        public DbSet<project.Models.CustomerType> CustomerType { get; set; }

        public DbSet<project.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<project.Models.Invoice> Invoice { get; set; }

        public DbSet<project.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<project.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<project.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<project.Models.PaymentType> PaymentType { get; set; }

        public DbSet<project.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<project.Models.Product> Product { get; set; }

        public DbSet<project.Models.ProductType> ProductType { get; set; }

        public DbSet<project.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<project.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<project.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<project.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<project.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<project.Models.SalesType> SalesType { get; set; }

        public DbSet<project.Models.Shipment> Shipment { get; set; }

        public DbSet<project.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<project.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<project.Models.Vendor> Vendor { get; set; }

        public DbSet<project.Models.VendorType> VendorType { get; set; }

        public DbSet<project.Models.Warehouse> Warehouse { get; set; }

        public DbSet<project.Models.UserProfile> UserProfile { get; set; }
    }
}
