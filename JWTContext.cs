using System;
using Microsoft.EntityFrameworkCore;
using Task16_BootcampRefactory.Model;

namespace Task16_BootcampRefactory
{
    public class JWTContext : DbContext
    {
        public JWTContext(DbContextOptions<JWTContext> opt): base(opt) { }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Products> products { get; set; }
    }
}
