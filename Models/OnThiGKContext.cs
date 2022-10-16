using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace OnThiGK.Models;
public class OnThiGKContext : DbContext
{
    public DbSet<Class> Classes { get; set; }
    public DbSet<School> Schools {get;set;}
    public DbSet<Student> Students {get;set;}

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     builder.Entity<Product>()
    //     .HasOne(p=> p.Category)
    //     .WithMany(c=> c.Products)
    //       .OnDelete(DeleteBehavior.Cascade)
    //     .HasForeignKey(p => p.CategoryId);
    //     base.OnModelCreating(builder);
        
    // }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=model.db");

    public string DbPath { get; }
    public OnThiGKContext(DbContextOptions<OnThiGKContext> options)
        : base(options){
        
    }
   

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
  
}