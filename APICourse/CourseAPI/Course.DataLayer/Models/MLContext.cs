using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Course.DataLayer.Models
{
    public partial class MLContext : DbContext
    {
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AlbumArtist> AlbumArtist { get; set; }
        public virtual DbSet<AlbumSong> AlbumSong { get; set; }
        public virtual DbSet<ArtistBand> ArtistBand { get; set; }
        public virtual DbSet<ArtistType> ArtistType { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlayListSong> PlayListSong { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=SCMWS004\SQLEXPRESS;Database=Ang4DB;Persist Security Info=True;User ID=LEadmin;Password=@Dev.Scio.18");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Producer).IsUnicode(false);
            });

            modelBuilder.Entity<AlbumArtist>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumArtist)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_AlbumArtist_Album");

                entity.HasOne(d => d.ArtistBand)
                    .WithMany(p => p.AlbumArtist)
                    .HasForeignKey(d => d.ArtistBandId)
                    .HasConstraintName("FK_AlbumArtist_ArtistBand");
            });

            modelBuilder.Entity<AlbumSong>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Image).IsUnicode(false);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumSong)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_AlbumSong_Album");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.AlbumSong)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("FK_AlbumSong_Song");
            });

            modelBuilder.Entity<ArtistBand>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bio).IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.ArtistType)
                    .WithMany(p => p.ArtistBand)
                    .HasForeignKey(d => d.ArtistTypeId)
                    .HasConstraintName("FK_ArtistBand_ArtistType");
            });

            modelBuilder.Entity<ArtistType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayListSong>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PlayList)
                    .WithMany(p => p.PlayListSong)
                    .HasForeignKey(d => d.PlayListId)
                    .HasConstraintName("FK_PlayListSong_PlayList");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.PlayListSong)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("FK_PlayListSong_Song");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AspNetUserId).IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);
            });
        }
    }
}
