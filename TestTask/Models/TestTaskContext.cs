using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace TestTask.Models
{
    public partial class TestTaskContext : DbContext
    {
        public TestTaskContext() { }

        public TestTaskContext(DbContextOptions<TestTaskContext> options) : base(options) { }

        public virtual DbSet<DepModel> Deps { get; set; }
        public virtual DbSet<PostModel> Posts { get; set; }
        public virtual DbSet<StatusModel> Statuses { get; set; }
        public virtual DbSet<PersonModel> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Чтение строки подключения из App.config
                string connectionString = GetConnectionString();
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        private string GetConnectionString(string name = "DefaultConnection")
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings[name];
                if (connectionString == null)
                {
                    throw new Exception($"Connection string '{name}' not found in App.config");
                }

                return connectionString.ConnectionString;
            }
            catch (Exception ex)
            { return null; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusModel>(entity =>
            {
                entity.ToTable("status");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("name");
            });

            modelBuilder.Entity<PostModel>(entity =>
            {
                entity.ToTable("posts");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("name");
            });

            modelBuilder.Entity<DepModel>(entity =>
            {
                entity.ToTable("deps");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("name");
            });

            modelBuilder.Entity<PersonModel>(entity =>
            {
                entity.ToTable("persons");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.FirstName)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("first_name");
                entity.Property(e => e.SecondName)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("second_name");
                entity.Property(e => e.LastName)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("last_name");
                entity.Property(e => e.DateEmploy)
                      .HasColumnName("date_employ");
                entity.Property(e => e.DateUnemploy)
                      .HasColumnName("date_unemploy");
                entity.Property(e => e.StatusId)
                      .HasColumnName("status");
                entity.Property(e => e.DepId)
                      .HasColumnName("id_dep");
                entity.Property(e => e.PostId)
                      .HasColumnName("id_post");

                // Настройка отношений
                entity.HasOne(d => d.Status)
                      .WithMany(p => p.Persons)
                      .HasForeignKey(d => d.StatusId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Person_Status");

                entity.HasOne(d => d.Dep)
                      .WithMany(p => p.Persons)
                      .HasForeignKey(d => d.DepId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Person_Dep");

                entity.HasOne(d => d.Post)
                      .WithMany(p => p.Persons)
                      .HasForeignKey(d => d.PostId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Person_Post");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

