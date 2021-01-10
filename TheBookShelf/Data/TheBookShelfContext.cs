using System;
using TheBookShelf;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TheBookShelf
{
    public partial class TheBookShelfContext : DbContext
    {
        public TheBookShelfContext()
        {
        }

        public TheBookShelfContext(DbContextOptions<TheBookShelfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Butiker> Butikers { get; set; }
        public virtual DbSet<ButikinfoBöckerPerGenre> ButikinfoBöckerPerGenres { get; set; }
        public virtual DbSet<Böcker> Böckers { get; set; }
        public virtual DbSet<Författare> Författares { get; set; }
        public virtual DbSet<FörfattareBöcker> FörfattareBöckers { get; set; }
        public virtual DbSet<Förlag> Förlags { get; set; }
        public virtual DbSet<Genrer> Genrers { get; set; }
        public virtual DbSet<Kunder> Kunders { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }
        public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattares { get; set; }
        public virtual DbSet<Översättare> Översättares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Kolla hur jag flyttar ut denna stringen till en säkrare plats
            optionsBuilder.UseSqlServer("Server=localhost;Database=TheBookShelf;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.ToTable("Butiker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Stad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ButikinfoBöckerPerGenre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ButikinfoBöckerPerGenre");

                entity.Property(e => e.AntalBöcker).HasColumnName("Antal böcker");

                entity.Property(e => e.Butik)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Böcker)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Förlag)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LagervärdeSek).HasColumnName("Lagervärde(sek)");
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn)
                    .ValueGeneratedNever()
                    .HasColumnName("ISBN");

                entity.Property(e => e.BetygAvNiclas).HasColumnName("Betyg av Niclas");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FörlagsId).HasColumnName("FörlagsID");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.Originaltitel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Språk)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Utgivningsdatum).HasColumnType("date");

                entity.Property(e => e.ÖversättareId).HasColumnName("ÖversättareID");

                entity.HasOne(d => d.Förlags)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.FörlagsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Förlag");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Genrer");

                entity.HasOne(d => d.Översättare)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.ÖversättareId)
                    .HasConstraintName("FK_Böcker_Översättare");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Födelsedatum).HasColumnType("date");

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kön)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Nationalitet)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FörfattareBöcker>(entity =>
            {
                entity.HasKey(fb => new { fb.FörfattareId, fb.Isbn });

                entity.ToTable("FörfattareBöcker");

                entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.HasOne(d => d.Författare)
                    .WithMany(f => f.FörfattareBöckers)
                    .HasForeignKey(d => d.FörfattareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FörfattareBöcker_Författare");

                entity.HasOne(d => d.IsbnFörfattare)
                    .WithMany(isbnf => isbnf.FörfattareBöckers)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FörfattareBöcker_Böcker");
            });

            modelBuilder.Entity<Förlag>(entity =>
            {
                entity.ToTable("Förlag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Stad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genrer>(entity =>
            {
                entity.ToTable("Genrer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kunder>(entity =>
            {
                entity.ToTable("Kunder");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Födelsedatum).HasColumnType("date");

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kön)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistreradButikId).HasColumnName("RegistreradButikID");

                entity.Property(e => e.Stad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.RegistreradButik)
                    .WithMany(p => p.Kunders)
                    .HasForeignKey(d => d.RegistreradButikId)
                    .HasConstraintName("FK_Kunder_Butiker");
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.ButikId, e.Isbn });

                entity.ToTable("LagerSaldo");

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.HasOne(d => d.Butik)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                entity.HasOne(d => d.IsbnSaldo)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Böcker");
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.AntalTitlar).HasColumnName("Antal titlar");

                entity.Property(e => e.Namn)
                    .HasMaxLength(201)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Översättare>(entity =>
            {
                entity.ToTable("Översättare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
