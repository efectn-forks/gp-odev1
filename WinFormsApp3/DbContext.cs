using Microsoft.EntityFrameworkCore;
using System;
using WinFormsApp3;

public class AppDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=people.db");
    }
}
