using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.DB;

public class ApiContext : DbContext
{
    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
    }

    public DbSet<Item> Items { get; set; }
}