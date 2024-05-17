using Microsoft.EntityFrameworkCore;
using MyContactApp.Models;

namespace MyContactApp.Data
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=contactapp;User=edu;Password=123;", new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}