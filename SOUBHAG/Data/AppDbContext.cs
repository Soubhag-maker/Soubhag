using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOUBHAG.Entity;

namespace SOUBHAG.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ba1300Entity> ba1300 { get; set; }
        public DbSet<LoginEntity> ba1110 { get; set; }
        public DbSet<adm0001Entity> Adm0001 { get; set; }
        //public DbSet<ba1110Entity> ba1110 { get; set; }
        public DbSet<ba1111Entity> ba1111 { get; set; }
        public DbSet<Usr0050Entity> usr0050 { get; set; }
        public DbSet<Usr0051Entity> usr0051 { get; set; }
    
    }
}
