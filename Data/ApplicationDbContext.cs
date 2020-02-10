using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HubbleGalaxyHotelApp.Models;
using Microsoft.AspNetCore.Identity;

namespace HubbleGalaxyHotelApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Create User
            ApplicationUser user = new ApplicationUser
            {
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                FirstName = "Buzz",
                LastName = "Lightyear",
                PhoneNumber = "123-456-7890",

            };

            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin123!");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create a paymentTypes
            modelBuilder.Entity<PaymentType>().HasData(
                    new PaymentType()
                    {
                        Id = 1,
                        AccountNumber = "4560857498651258",
                        NameOfAccount = "Chase Visa",
                        UserId = "00000000-ffff-ffff-ffff-ffffffffffff",

                    }
                    );

            // Create a Reservation
            modelBuilder.Entity<Reservation>().HasData(
                    new Reservation()
                    {
                        Id = 1,
                        RoomId = 1,
                        PaymentTypeId = 1,
                        UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                        StartDate = new DateTime(2020, 01, 08),
                        EndDate = new DateTime(2020, 01, 09)
                        

                    }
                    );

            // Create a Room
            modelBuilder.Entity<Room>().HasData(
                    new Room()
                    {
                        Id = 1,
                        RoomName = "Galaxy Pod",
                        PricePerNight = 108.00,
                        RoomDescription = "Room Service to Major Tom",
                        RoomFeatures = "A spaceship bed",
                        RoomImage = "https://i.imgur.com/VbQIyjw.jpg"



                    },
                    new Room()
                    {
                        Id = 2,
                        RoomName = "Hubble Galaxy Suite",
                        PricePerNight = 200.00,
                        RoomDescription = "Nebula ceiling",
                        RoomFeatures = "Zero gravity capsule",
                        RoomImage = "https://i.imgur.com/5whB7Zk.jpg"
                    }
                    );

        }
    }
}
