using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class StaySafeDBContext : DbContext
    {


        public StaySafeDBContext(DbContextOptions<StaySafeDBContext> options) : base(options)
        {

        }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CityInfo> CityInfos { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Aminity> Aminities { get; set; }
        public DbSet<BedType> BedTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingType> BookingTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Highlights> Highlights { get; set; }
        public DbSet<HotelHasHighlights> HotelHasHighlights { get; set; }
        public DbSet<HotelHasRoomType> HotelHasRoomTypes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAminity> RoomAminities { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Owner>()
            .HasOne(f => f.Hotel)
            .WithMany(s => s.Owners)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Manager>()
            .HasOne(f => f.Owner)
            .WithMany(s => s.Managers)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Room>()
             .HasOne(f => f.Manager)
             .WithMany(s => s.Rooms)
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>()
            .HasOne(f => f.Room)
            .WithMany(s => s.Bookings)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
