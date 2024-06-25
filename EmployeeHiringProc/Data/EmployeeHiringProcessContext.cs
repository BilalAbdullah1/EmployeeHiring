using System;
using System.Collections.Generic;
using EmployeeHiringProc.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeHiringProc.Data;

public partial class EmployeeHiringProcessContext : DbContext
{
    public EmployeeHiringProcessContext()
    {
    }

    public EmployeeHiringProcessContext(DbContextOptions<EmployeeHiringProcessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Availibility> Availibilities { get; set; }

    public virtual DbSet<EmpExperience> EmpExperiences { get; set; }

    public virtual DbSet<EmpExperienceAdd> EmpExperienceAdds { get; set; }

    public virtual DbSet<EmpGender> EmpGenders { get; set; }

    public virtual DbSet<EmpHighestDegree> EmpHighestDegrees { get; set; }

    public virtual DbSet<EmpSubjectTaught> EmpSubjectTaughts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<GradeLevelsTaught> GradeLevelsTaughts { get; set; }

    public virtual DbSet<PreferredTeachinglvl> PreferredTeachinglvls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PO6TBST\\MYSERVER;Initial Catalog=EmployeeHiringProcess;User ID=sa;Password=hexor;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Availibility>(entity =>
        {
            entity.HasKey(e => e.EmpAvlId).HasName("PK__Availibi__3AFAA617B6417640");

            entity.ToTable("Availibility");

            entity.Property(e => e.AvailTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpExperience>(entity =>
        {
            entity.HasKey(e => e.EmpExpId).HasName("PK__EmpExper__16691748980FB247");

            entity.ToTable("EmpExperience");

            entity.Property(e => e.Experience)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpExperienceAdd>(entity =>
        {
            entity.HasKey(e => e.EmpExpAddId).HasName("PK__EmpExper__6BC6C96AA25D1DF4");

            entity.ToTable("EmpExperienceAdd");

            entity.Property(e => e.ExperienceAdd)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpGender>(entity =>
        {
            entity.HasKey(e => e.EmpGid).HasName("PK__EmpGende__D1F3708DFA355B22");

            entity.ToTable("EmpGender");

            entity.Property(e => e.EmpGid).HasColumnName("EmpGId");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpHighestDegree>(entity =>
        {
            entity.HasKey(e => e.EmpHdid).HasName("PK__EmpHighe__037DE9CEDB5EBC3D");

            entity.ToTable("EmpHighestDegree");

            entity.Property(e => e.EmpHdid).HasColumnName("EmpHDId");
            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpSubjectTaught>(entity =>
        {
            entity.HasKey(e => e.EmpStid).HasName("PK__EmpSubje__C024471E2EECBB8B");

            entity.ToTable("EmpSubjectTaught");

            entity.Property(e => e.EmpStid).HasColumnName("EmpSTId");
            entity.Property(e => e.Subjects)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBB997472FB1C");

            entity.ToTable("Employee");

            entity.Property(e => e.Address)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.AreasOfExpertise)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Certificate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentEmployer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FieldOfStudy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.ImageFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("imageFile");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UploadFile).HasMaxLength(100);

            entity.HasOne(d => d.Avail).WithMany(p => p.Employees)
                .HasForeignKey(d => d.AvailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdditionalInformation_Availibility");

            entity.HasOne(d => d.Degree).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DegreeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalInfo_EmpDegree");

            entity.HasOne(d => d.Experience).WithMany(p => p.Employees)
                .HasForeignKey(d => d.ExperienceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalInfo_EmpExperience");

            entity.HasOne(d => d.ExperienceIdAddNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.ExperienceIdAdd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdditionalInformation_EmpExperience");

            entity.HasOne(d => d.Gender).WithMany(p => p.Employees)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpPersonalInfo_EmpGender");

            entity.HasOne(d => d.Grade).WithMany(p => p.Employees)
                .HasForeignKey(d => d.GradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalInfo_EmpGrade");

            entity.HasOne(d => d.Subject).WithMany(p => p.Employees)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalInfo_EmpSubjects");

            entity.HasOne(d => d.TeachingLvls).WithMany(p => p.Employees)
                .HasForeignKey(d => d.TeachingLvlsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdditionalInformation_PreferredTeachinglvls");
        });

        modelBuilder.Entity<GradeLevelsTaught>(entity =>
        {
            entity.HasKey(e => e.EmpGrdId).HasName("PK__GradeLev__AE8F0B7E07D3B0B0");

            entity.ToTable("GradeLevelsTaught");

            entity.Property(e => e.Grade)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PreferredTeachinglvl>(entity =>
        {
            entity.HasKey(e => e.EmpptId).HasName("PK__Preferre__89826BC4D3A73CD7");

            entity.Property(e => e.TeachingLevels)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
