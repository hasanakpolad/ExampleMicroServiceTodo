using ExampleMicroServiceUser.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceUser.DataAccess.Context
{
    public class UserContext : DbContext
    {
        public UserContext()
        {

        }
        public DbSet<UserModel> UserModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost;Database=mstododb;Uid=root;Pwd=root;", ServerVersion.AutoDetect("Server=localhost;Database=msuserdb;Uid=root;Pwd=root;"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserModel>().HasKey(x => x.Id);
        }
    }
}
