using Microsoft.EntityFrameworkCore;
using System;
using TaskApi.Modals;

namespace TaskApi.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Server=THENUKA\\MSSQLSERVER19; Database=MyTodoDB; User Id=dev; Password=12345";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] {
                new Author { Id = 1, FullName = "Thenuka Jayarathna", AddressNo = "45", Street = "street 1", City = "Colombo 1", JobRole = "Developer" },
                new Author { Id = 2, FullName = "Pubudu Gamage", AddressNo = "22", Street = "street 2", City = "Colombo 5", JobRole = "Systems Engineer" },
                new Author { Id = 3, FullName = "Nishadi Hansika", AddressNo = "14", Street = "street 4", City = "Kandy", JobRole = "Developer" },
                new Author { Id = 4, FullName = "Nipun Gallage", AddressNo = "55", Street = "street 5", City = "Nugegoda", JobRole = "QA" },
                new Author { Id = 5, FullName = "Isuru Anjana", AddressNo = "422/1", Street = "street 6", City = "Galle", JobRole = "Developer" }
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[] {
                new Todo
                {
                    Id = 1,
                    Title = "Get books for school",
                    Description = "Get some text books for school",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 2,
                    Title = "Shopping for next week",
                    Description = "Get some food for next week",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.New,
                    AuthorId = 5
                },
                new Todo
                {
                    Id = 3,
                    Title = "Do some programming practice",
                    Description = "Practice programming",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.New,
                    AuthorId = 3
                },
                new Todo
                {
                    Id = 4,
                    Title = "Clean room",
                    Description = "Clean the room",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 5,
                    Title = "Workout for 30 minutes",
                    Description = "Finish daily workout",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.New,
                    AuthorId = 4
                }
            });
        }
    }
}