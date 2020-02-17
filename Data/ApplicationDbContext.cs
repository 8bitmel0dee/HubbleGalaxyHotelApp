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
                        RoomDescription = "Room Service to Major Tom.",
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
                    },

                    new Room()
                    {
                        Id = 3,
                        RoomName = "Whimsical Red Spaceship",
                        PricePerNight = 108.00,
                        RoomDescription = "Take a ride in this floor-to-ceiling rocket.",
                        RoomFeatures = "A few friendly alien guests",
                        RoomImage = "https://i.imgur.com/P26tsGG.jpg"
                    },

                    new Room()
                    {
                        Id = 4,
                        RoomName = "Space Odyssey Suite",
                        PricePerNight = 236.00,
                        RoomDescription = "Experience the feeling of flying among the stars.",
                        RoomFeatures = "Triangular whirlpool bath that glows softly under the stars. Steam shower. Wet bar.",
                        RoomImage = "https://i.imgur.com/4v2J8y5.jpg"
                    },

                    new Room()
                    {
                        Id = 5,
                        RoomName = "Outer Space Room",
                        PricePerNight = 182.00,
                        RoomDescription = "Sleep in a giant crater dressed with astronaut spacesuit bedding as you look up to the planets and stars above.",
                        RoomFeatures = "Voyages for little ones in a mini-rocket. In-room telescope. Sea-view balcony.",
                        RoomImage = "https://i.imgur.com/leY3lUu.png"
                    },

                    new Room()
                    {
                        Id = 6,
                        RoomName = "Gemini Space Capsule",
                        PricePerNight = 150.00,
                        RoomDescription = "Replica of NASA's Gemini capsule",
                        RoomFeatures = "Oversized “moon crater” whirlpool",
                        RoomImage = "https://i.imgur.com/FHsPwrE.jpg"
                    },

                    new Room()
                    {
                        Id = 7,
                        RoomName = "Futuristic Space Capsule",
                        PricePerNight = 200.00,
                        RoomDescription = "Rooms are so yesterday. Stay in a sleeping capsule!",
                        RoomFeatures = "Staffed by friendly robots",
                        RoomImage = "https://i.imgur.com/zU3b0vF.jpg"
                    },

                    new Room()
                    {
                        Id = 8,
                        RoomName = "Liquid Gravity Moon Suite",
                        PricePerNight = 1600.00,
                        RoomDescription = "Decorated with an ultimate commitment to extraterrestrial design, this stunning room makes you feel transported straight to the moon.",
                        RoomFeatures = "King-size bed designed to look like it is floating in the air. Inspired by the movie 2001.",
                        RoomImage = "https://i.imgur.com/x6YoYWX.jpg"
                    }

                    );

        }
    }
}
