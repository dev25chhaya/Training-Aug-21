using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace assignment.Models
{
    public partial class hospitalContext : DbContext
    {
        public hospitalContext()
        {
        }

        public hospitalContext(DbContextOptions<hospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugSchedual> DrugScheduals { get; set; }
        public virtual DbSet<HealthcareAss> HealthcareAsses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=hospital;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("departmentId_PK");

                entity.ToTable("departments");

                entity.Property(e => e.DeptId).HasColumnName("deptId");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptName");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctor");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("doctor_departmentid_FK");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("drugs");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Timing)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugSchedual>(entity =>
            {
                entity.ToTable("drugSchedual");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.DrugScheduals)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("drugSchedual_drugid_FK");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DrugScheduals)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("drugSchedual_patientid_FK");
            });

            modelBuilder.Entity<HealthcareAss>(entity =>
            {
                entity.ToTable("healthcareAss");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HealthcareAsses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("healthcareAss_departmentid_FK");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assistance)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.AssistanceId)
                    .HasConstraintName("patient_assistanceid_FK");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("patient_departmentid_FK");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.ToTable("treatment");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("treatment_doctorid_FK");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("treatment_patientid_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
