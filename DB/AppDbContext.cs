﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DominoAvancadoComEf.DB
{
    public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
