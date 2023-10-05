using System;
using EF_Library_Database_HW.Entyties;
using Microsoft.EntityFrameworkCore;

namespace EF_Library_Database_HW.Contexts;

public class LibraryDbContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Data Source=ASUSTUFGAMING\\SQLEXPRESS01;Database=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }

    // Tables

    public DbSet<Books> Books { get; set; }
    public DbSet<Authors> Authors { get; set; }
    public DbSet<BooksTypes> BookTypes { get; set; }
    public DbSet<Operations> Operations { get; set; }
    public DbSet<Students> Students { get; set; }

}