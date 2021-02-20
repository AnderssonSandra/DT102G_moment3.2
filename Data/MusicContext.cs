using DT102G_moment3._2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_moment3._2.Data
{
    public class MusicContext : DbContext
    {
        //constructor
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }
        //propertys
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Cd> Cd { get; set; }
    }
}
