﻿using CafeForGames.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeForGames.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Games> Games { get; set; }
        public DbSet<LocalUser> Users { get; set; }
    }
}
