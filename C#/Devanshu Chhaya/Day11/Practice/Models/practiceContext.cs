using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFcorePrac.Models
{
    public partial class practiceContext : DbContext
    {
        public practiceContext()
        {
        }

        public practiceContext(DbContextOptions<practiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=practice;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Countrie__10D160BF88A3A866");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__Departme__B2079BCDAF4E9544");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("ManagerID")
                    .HasColumnType("decimal(6, 0)");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("pkEmployeeID");

                entity.HasIndex(e => e.Email)
                    .HasName("ukEmail")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("decimal(6, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CommissionPct).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("ManagerID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA477731A5E65");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
