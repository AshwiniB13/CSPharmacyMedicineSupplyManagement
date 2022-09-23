using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CSPharmacyMedicineSupplyManagement.Models
{
    public partial class PharmacyMedicineSupplyManagementContext : DbContext
    {
        public PharmacyMedicineSupplyManagementContext()
        {
        }

        public PharmacyMedicineSupplyManagementContext(DbContextOptions<PharmacyMedicineSupplyManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MedicineStock> MedicineStocks { get; set; }
        public virtual DbSet<PharmacyMedicineSupply> PharmacyMedicineSupplies { get; set; }
        public virtual DbSet<RepSchedule> RepSchedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.9.246.162,4022;Database=PharmacyMedicineSupplyManagement;User ID=sa;pwd=CreateFile();");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MedicineStock>(entity =>
            {
                entity.HasKey(e => e.Msid)
                    .HasName("PK__Medicine__6CBE556B93619A19");

                entity.ToTable("MedicineStock");

                entity.Property(e => e.Msid).HasColumnName("MSid");

                entity.Property(e => e.ChemicalComposition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfExpiry).HasColumnType("date");

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TargetAilment)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PharmacyMedicineSupply>(entity =>
            {
                entity.HasKey(e => e.Pmsid)
                    .HasName("PK__Pharmacy__8D9686CA0DEB6BA6");

                entity.ToTable("PharmacyMedicineSupply");

                entity.Property(e => e.Pmsid).HasColumnName("PMSID");

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PharmacyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepSchedule>(entity =>
            {
                entity.HasKey(e => e.Rsid)
                    .HasName("PK__RepSched__E0C61B005DBABB55");

                entity.ToTable("RepSchedule");

                entity.Property(e => e.Rsid).HasColumnName("RSid");

                entity.Property(e => e.DateOfMeeting).HasColumnType("date");

                entity.Property(e => e.DoctorContactNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Doctorname)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Medicine)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingSlot)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TreatingAilment)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
