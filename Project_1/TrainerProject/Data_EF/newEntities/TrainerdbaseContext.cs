using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_EF.newEntities;

public partial class TrainerdbaseContext : DbContext
{
    public TrainerdbaseContext()
    {
    }

    public TrainerdbaseContext(DbContextOptions<TrainerdbaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }

    public virtual DbSet<EducationDetail> EducationDetails { get; set; }

    public virtual DbSet<SkillsDetail> SkillsDetails { get; set; }

    public virtual DbSet<TrainerDetail> TrainerDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MOUNIKA;Database=Trainerdbase;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Company___B9BE370F97DEDA85");

            entity.ToTable("Company_Detail");

            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Experience)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.CompanyDetail)
                .HasForeignKey<CompanyDetail>(d => d.UserId)
                .HasConstraintName("Fk_CompanyDetails");
        });

        modelBuilder.Entity<EducationDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Educatio__B9BE370F3F875F21");

            entity.ToTable("Education_Details");

            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Degree)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("institutionName");
            entity.Property(e => e.PassingYear).IsUnicode(false);
            entity.Property(e => e.Specialization)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.EducationDetail)
                .HasForeignKey<EducationDetail>(d => d.UserId)
                .HasConstraintName("FK-education");
        });

        modelBuilder.Entity<SkillsDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Skills_D__B9BE370F507A2519");

            entity.ToTable("Skills_Details");

            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Skill1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Skill2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Skill3)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.SkillsDetail)
                .HasForeignKey<SkillsDetail>(d => d.UserId)
                .HasConstraintName("FK-skill");
        });

        modelBuilder.Entity<TrainerDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__TrainerD__B9BE370F3C17910D");

            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.EmailId)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
