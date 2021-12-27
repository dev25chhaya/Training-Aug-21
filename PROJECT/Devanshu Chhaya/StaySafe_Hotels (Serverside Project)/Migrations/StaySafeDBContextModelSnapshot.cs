﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StaySafeHotels.Models;

namespace StaySafeHotels.Migrations
{
    [DbContext(typeof(StaySafeDBContext))]
    partial class StaySafeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StaySafeHotels.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Aminity", b =>
                {
                    b.Property<int>("AminityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AminintyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("AminityId");

                    b.ToTable("Aminities");
                });

            modelBuilder.Entity("StaySafeHotels.Models.BedType", b =>
                {
                    b.Property<int>("BedTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BedCapacity")
                        .HasColumnType("int");

                    b.Property<string>("BedTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BedTypeId");

                    b.ToTable("BedTypes");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Booking", b =>
                {
                    b.Property<int>("BookigID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookingTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentTypeID")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("ReservationID")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TotalNoOfGuest")
                        .HasColumnType("int");

                    b.HasKey("BookigID");

                    b.HasIndex("BookingTypeId");

                    b.HasIndex("PaymentTypeID");

                    b.HasIndex("ReservationID");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("StaySafeHotels.Models.BookingType", b =>
                {
                    b.Property<int>("BookingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingTypeId");

                    b.ToTable("BookingTypes");
                });

            modelBuilder.Entity("StaySafeHotels.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("StaySafeHotels.Models.CityInfo", b =>
                {
                    b.Property<int>("CityInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BestTimeToVisit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("HowToReach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CityInfoId");

                    b.HasIndex("CityID");

                    b.ToTable("CityInfos");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EamilID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Highlights", b =>
                {
                    b.Property<int>("HighlightsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HighlightsId");

                    b.ToTable("Highlights");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusStationDistanceInKM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OverView")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber1")
                        .HasColumnType("bigint");

                    b.Property<long>("PhoneNumber2")
                        .HasColumnType("bigint");

                    b.Property<string>("RailwayStationDistanceInKM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.HasIndex("CityID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("StaySafeHotels.Models.HotelHasHighlights", b =>
                {
                    b.Property<int>("HotelHasHighlightsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HighlightsId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("HotelHasHighlightsID");

                    b.HasIndex("HighlightsId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelHasHighlights");
                });

            modelBuilder.Entity("StaySafeHotels.Models.HotelHasRoomType", b =>
                {
                    b.Property<int>("HotelHasRoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("HotelHasRoomTypeId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("HotelHasRoomTypes");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("ManagerID");

                    b.HasIndex("CityID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OwnerFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("OwnerID");

                    b.HasIndex("CityID");

                    b.HasIndex("HotelId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("StaySafeHotels.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeID");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("ReservationID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BedTypeId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ManagerID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SquareFeet")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.HasIndex("BedTypeId");

                    b.HasIndex("HotelId");

                    b.HasIndex("ManagerID");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("StaySafeHotels.Models.RoomAminity", b =>
                {
                    b.Property<int>("RoomAminityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AminityId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("RoomAminityID");

                    b.HasIndex("AminityId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomAminities");
                });

            modelBuilder.Entity("StaySafeHotels.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CancellationPolicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MaximumCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatePerNight")
                        .HasColumnType("int");

                    b.Property<int>("RatePerNightWithBreakfast")
                        .HasColumnType("int");

                    b.Property<string>("RoomInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("StaySafeHotels.Models.State", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.ToTable("States");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Booking", b =>
                {
                    b.HasOne("StaySafeHotels.Models.BookingType", "BookingType")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.PaymentType", "PaymentType")
                        .WithMany("Bookings")
                        .HasForeignKey("PaymentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Reservation", "Reservation")
                        .WithMany("Bookings")
                        .HasForeignKey("ReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BookingType");

                    b.Navigation("PaymentType");

                    b.Navigation("Reservation");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("StaySafeHotels.Models.City", b =>
                {
                    b.HasOne("StaySafeHotels.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("StaySafeHotels.Models.CityInfo", b =>
                {
                    b.HasOne("StaySafeHotels.Models.City", "City")
                        .WithMany("cityInfos")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Hotel", b =>
                {
                    b.HasOne("StaySafeHotels.Models.City", "City")
                        .WithMany("Hotels")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("StaySafeHotels.Models.HotelHasHighlights", b =>
                {
                    b.HasOne("StaySafeHotels.Models.Highlights", "Highlights")
                        .WithMany("HotelHasHighlight")
                        .HasForeignKey("HighlightsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Hotel", "Hotel")
                        .WithMany("HotelHasHighlights")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Highlights");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("StaySafeHotels.Models.HotelHasRoomType", b =>
                {
                    b.HasOne("StaySafeHotels.Models.Hotel", "Hotel")
                        .WithMany("HotelHasRoomTypes")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.RoomType", "RoomType")
                        .WithMany("HotelHasRoomTypes")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Manager", b =>
                {
                    b.HasOne("StaySafeHotels.Models.City", "City")
                        .WithMany("Managers")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Owner", "Owner")
                        .WithMany("Managers")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Owner", b =>
                {
                    b.HasOne("StaySafeHotels.Models.City", "City")
                        .WithMany("Owners")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Hotel", "Hotel")
                        .WithMany("Owners")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Reservation", b =>
                {
                    b.HasOne("StaySafeHotels.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Room", b =>
                {
                    b.HasOne("StaySafeHotels.Models.BedType", "BedType")
                        .WithMany("Rooms")
                        .HasForeignKey("BedTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Manager", "Manager")
                        .WithMany("Rooms")
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BedType");

                    b.Navigation("Hotel");

                    b.Navigation("Manager");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("StaySafeHotels.Models.RoomAminity", b =>
                {
                    b.HasOne("StaySafeHotels.Models.Aminity", "Aminity")
                        .WithMany("RoomAminities")
                        .HasForeignKey("AminityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaySafeHotels.Models.Room", "Room")
                        .WithMany("RoomAminities")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aminity");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Aminity", b =>
                {
                    b.Navigation("RoomAminities");
                });

            modelBuilder.Entity("StaySafeHotels.Models.BedType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("StaySafeHotels.Models.BookingType", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("StaySafeHotels.Models.City", b =>
                {
                    b.Navigation("cityInfos");

                    b.Navigation("Hotels");

                    b.Navigation("Managers");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Highlights", b =>
                {
                    b.Navigation("HotelHasHighlight");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Hotel", b =>
                {
                    b.Navigation("HotelHasHighlights");

                    b.Navigation("HotelHasRoomTypes");

                    b.Navigation("Owners");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Manager", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Owner", b =>
                {
                    b.Navigation("Managers");
                });

            modelBuilder.Entity("StaySafeHotels.Models.PaymentType", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Reservation", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("StaySafeHotels.Models.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("RoomAminities");
                });

            modelBuilder.Entity("StaySafeHotels.Models.RoomType", b =>
                {
                    b.Navigation("HotelHasRoomTypes");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("StaySafeHotels.Models.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
