using Microsoft.EntityFrameworkCore;
using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;

namespace RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Configuration;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DoctorDetail> RecipesDoctor2024 { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySQL("Server=localhost;Database=db_doctor;User=root;Password=password;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("recipes_doctor_2024");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.YtdSun23)
                .HasMaxLength(15)
                .HasColumnName("ytd_sun23");
            entity.Property(e => e.Cmp)
                .HasMaxLength(20)
                .HasColumnName("cmp_medic");
            entity.Property(e => e.Department)
                .HasMaxLength(40)
                .HasColumnName("department");
            entity.Property(e => e.DescriptionLaboratory)
                .HasMaxLength(40)
                .HasColumnName("description_laboratory");
            entity.Property(e => e.Especiality)
                .HasMaxLength(35)
                .HasColumnName("speciality");
            entity.Property(e => e.Molecule)
                .HasMaxLength(50)
                .HasColumnName("molecule");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name_medic");
            entity.Property(e => e.YtdSun24)
                .HasMaxLength(15)
                .HasColumnName("ytd_sun24");
            entity.Property(e => e.QtrSetNov)
                .HasMaxLength(15)
                .HasColumnName("qtr_setNov");
            entity.Property(e => e.QtrDicFeb)
                .HasMaxLength(15)
                .HasColumnName("qtr_dicFeb");
            entity.Property(e => e.Surname)
                .HasMaxLength(40)
                .HasColumnName("surname_medic");
            entity.Property(e => e.QtrMarMay)
                .HasMaxLength(15)
                .HasColumnName("qtr_marMay");
            entity.Property(e => e.QtrJunAgo)
                .HasMaxLength(15)
                .HasColumnName("qtr_junAgo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
