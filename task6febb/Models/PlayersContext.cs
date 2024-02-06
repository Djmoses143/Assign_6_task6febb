using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace task6febb.Models
{
    public partial class PlayersContext : DbContext
    {
        public PlayersContext()
        {
        }

        public PlayersContext(DbContextOptions<PlayersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DJMOSES;database=Players;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("players");

                entity.Property(e => e.PlayerId).ValueGeneratedNever();

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Team)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
