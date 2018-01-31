﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PVMTrading_v1.Models.archieved;

namespace PVMTrading_v1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {


        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ProductCondition> ProductConditions { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<BrandType> BrandTypes { get; set; }
        public DbSet<ProductInclusion> ProductInclusions { get; set; }
        public DbSet<CivilStatus> CivilStatus { get; set; }


        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<LoanStatus> LoanStatus { get; set; }
        public DbSet<ModeOfPayment> ModeOfPayment { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Warranty> Warranty { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }

        public DbSet<CashTransaction> CashTransactions { get; set; }
        public DbSet<CashTransactionItem> CashTransactionItems { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


       
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

         }


   


}