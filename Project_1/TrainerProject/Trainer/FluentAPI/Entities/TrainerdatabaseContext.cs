using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Entities;

public partial class TrainerdatabaseContext : DbContext
{
    public TrainerdatabaseContext()
    {
    }

    public TrainerdatabaseContext(DbContextOptions<TrainerdatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }

    public virtual DbSet<EducationDetail> EducationDetails { get; set; }

    public virtual DbSet<SkillsDetail> SkillsDetails { get; set; }

    public virtual DbSet<TrainerDetail> TrainerDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:mounikaresource.database.windows.net,1433;Initial Catalog=Trainerdatabase; User ID=mounikaresource;Password=Mounika@1999;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Company___B9BE370F017AF318");

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
            entity.HasKey(e => e.UserId).HasName("PK__Educatio__B9BE370F968181BE");

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
            entity.HasKey(e => e.UserId).HasName("PK__Skills_D__B9BE370F8115A24E");

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
            entity.HasKey(e => e.UserId).HasName("PK__TrainerD__B9BE370F40E8056B");

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
