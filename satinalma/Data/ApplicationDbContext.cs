﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using satinalma.Models;
namespace satinalma.Data
{
    public class ApplicationDbContext :IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<customers> Customers { get; set; } 
        public DbSet<cart>Carts { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }   
        public DbSet<Orders> Orders { get; set; }
        public DbSet<categories> Categories { get; set; }   
        public DbSet<product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<product_reviews>product_Reviews { get; set; }  
        

    }
}
