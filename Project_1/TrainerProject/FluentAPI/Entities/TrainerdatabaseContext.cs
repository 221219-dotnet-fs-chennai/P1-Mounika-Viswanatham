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

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("Server=tcp:mounikaresource.database.windows.net,1433;Initial Catalog=Trainerdatabase;User ID=mounikaresource;Password=Mounika@1999;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Company___B9BE370F017AF318");

            entity.HasOne(d => d.User).WithOne(p => p.CompanyDetail).HasConstraintName("Fk_CompanyDetails");
        });

        modelBuilder.Entity<EducationDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Educatio__B9BE370F968181BE");

            entity.HasOne(d => d.User).WithOne(p => p.EducationDetail).HasConstraintName("FK-education");
        });

        modelBuilder.Entity<SkillsDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Skills_D__B9BE370F8115A24E");

            entity.HasOne(d => d.User).WithOne(p => p.SkillsDetail).HasConstraintName("FK-skill");
        });

        modelBuilder.Entity<TrainerDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__TrainerD__B9BE370F40E8056B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
