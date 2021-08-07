using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskApi.Modals;

namespace TaskApi.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Server=THENUKA\\MSSQLSERVER19; Database=MyTodoDB; User Id=dev; Password=12345";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get books for school - DB",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                States = TodoStatus.New
            });
        }
    }
}
