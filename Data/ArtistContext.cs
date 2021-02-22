using DT102G_ASP_NET_Moment3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_ASP_NET_Moment3.Data
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options)
        {
        }

        //Modeller som blir tabeller i databasen
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<User> User { get; set; }
    }
}
