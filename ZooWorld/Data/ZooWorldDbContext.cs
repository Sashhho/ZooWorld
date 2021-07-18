namespace ZooWorld.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ZooWorldDbContext : IdentityDbContext
    {
        public ZooWorldDbContext(DbContextOptions<ZooWorldDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
