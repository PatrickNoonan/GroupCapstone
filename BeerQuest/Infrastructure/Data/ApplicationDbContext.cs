using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain;
using BeerQuest.Models;

namespace Infrastructure.Data
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<ApplicationRole> Role { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
