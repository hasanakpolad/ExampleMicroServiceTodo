using ExampleMicroServiceTodo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceTodo.DataAccess.Context
{
    public class MasterContext : DbContext
    {
        public MasterContext()
        {

        }
        public DbSet<TodoModel> TodoModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost;Database=mstododb;Uid=root;Pwd=root;", ServerVersion.AutoDetect("Server=localhost;Database=mstododb;Uid=root;Pwd=root;"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TodoModel>().HasKey(x => x.Id);
        }
    }
}
