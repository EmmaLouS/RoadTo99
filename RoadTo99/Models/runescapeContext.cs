using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RoadTo99.Models
{
    public partial class runescapeContext : DbContext
    {
        public virtual DbSet<Highscore> Highscore { get; set; }
        public virtual DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=192.168.0.2\JAMIE\SQLExpress,1433;Database=runescape; ADD LOCAL LOGIN DETAILS HERE IF CLONING LOCALLY - FUTURE PLAN TO SET UP HOSTED WEB SERVICE FOR THIS;"); //TODO : add to config file
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Highscore>(entity =>
            {
                entity.HasKey(e => new { e.HighscoreId, e.PlayerId });

                entity.Property(e => e.HighscoreId).HasColumnName("HighscoreID");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.AgilityXp).HasColumnName("AgilityXP");

                entity.Property(e => e.AttackXp).HasColumnName("AttackXP");

                entity.Property(e => e.ConstructionXp).HasColumnName("ConstructionXP");

                entity.Property(e => e.CookingXp).HasColumnName("CookingXP");

                entity.Property(e => e.CraftingXp).HasColumnName("CraftingXP");

                entity.Property(e => e.DefenceXp).HasColumnName("DefenceXP");

                entity.Property(e => e.DownloadDate).HasColumnType("datetime");

                entity.Property(e => e.FarmingXp).HasColumnName("FarmingXP");

                entity.Property(e => e.FiremakingXp).HasColumnName("FiremakingXP");

                entity.Property(e => e.FishingXp).HasColumnName("FishingXP");

                entity.Property(e => e.FletchingXp).HasColumnName("FletchingXP");

                entity.Property(e => e.HerbloreXp).HasColumnName("HerbloreXP");

                entity.Property(e => e.HitpointsXp).HasColumnName("HitpointsXP");

                entity.Property(e => e.HunterXp).HasColumnName("HunterXP");

                entity.Property(e => e.MagicXp).HasColumnName("MagicXP");

                entity.Property(e => e.MiningXp).HasColumnName("MiningXP");

                entity.Property(e => e.PrayerXp).HasColumnName("PrayerXP");

                entity.Property(e => e.RangedXp).HasColumnName("RangedXP");

                entity.Property(e => e.RunecraftXp).HasColumnName("RunecraftXP");

                entity.Property(e => e.SlayerXp).HasColumnName("SlayerXP");

                entity.Property(e => e.SmithingXp).HasColumnName("SmithingXP");

                entity.Property(e => e.StrengthXp).HasColumnName("StrengthXP");

                entity.Property(e => e.ThievingXp).HasColumnName("ThievingXP");

                entity.Property(e => e.TotalXp).HasColumnName("TotalXP");

                entity.Property(e => e.WoodcuttingXp).HasColumnName("WoodcuttingXP");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Highscore)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Highscores_PlayerID_Players");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
