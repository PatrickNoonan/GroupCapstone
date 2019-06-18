using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure.Data
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
