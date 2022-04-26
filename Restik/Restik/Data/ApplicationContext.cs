using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restik.Models;
using System;
using System.IO;
using System.Windows;

namespace Restik.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var Builder = new ConfigurationBuilder();
            Builder.SetBasePath("C:\\Users\\ACER\\Desktop\\Projects\\restik\\Restik\\Restik");
            Builder.AddJsonFile("config.json");
            var Config = Builder.Build();
            string ConnectionString = Config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
