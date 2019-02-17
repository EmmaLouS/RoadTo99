using System;
using System.Collections.Generic;

namespace RoadTo99.Models
{
    public partial class Highscore
    {
        public int HighscoreId { get; set; }
        public int PlayerId { get; set; }
        public DateTime DownloadDate { get; set; }
        public int TotalRank { get; set; }
        public int TotalLevel { get; set; }
        public double TotalXp { get; set; }
        public int AttackRank { get; set; }
        public int AttackLevel { get; set; }
        public int AttackXp { get; set; }
        public int DefenceRank { get; set; }
        public int DefenceLevel { get; set; }
        public int DefenceXp { get; set; }
        public int StrengthRank { get; set; }
        public int StrengthLevel { get; set; }
        public int StrengthXp { get; set; }
        public int HitpointsRank { get; set; }
        public int HitpointsLevel { get; set; }
        public int HitpointsXp { get; set; }
        public int RangedRank { get; set; }
        public int RangedLevel { get; set; }
        public int RangedXp { get; set; }
        public int PrayerRank { get; set; }
        public int PrayerLevel { get; set; }
        public int PrayerXp { get; set; }
        public int MagicRank { get; set; }
        public int MagicLevel { get; set; }
        public int MagicXp { get; set; }
        public int CookingRank { get; set; }
        public int CookingLevel { get; set; }
        public int CookingXp { get; set; }
        public int WoodcuttingRank { get; set; }
        public int WoodcuttingLevel { get; set; }
        public int WoodcuttingXp { get; set; }
        public int FletchingRank { get; set; }
        public int FletchingLevel { get; set; }
        public int FletchingXp { get; set; }
        public int FishingRank { get; set; }
        public int FishingLevel { get; set; }
        public int FishingXp { get; set; }
        public int FiremakingRank { get; set; }
        public int FiremakingLevel { get; set; }
        public int FiremakingXp { get; set; }
        public int CraftingRank { get; set; }
        public int CraftingLevel { get; set; }
        public int CraftingXp { get; set; }
        public int SmithingRank { get; set; }
        public int SmithingLevel { get; set; }
        public int SmithingXp { get; set; }
        public int MiningRank { get; set; }
        public int MiningLevel { get; set; }
        public int MiningXp { get; set; }
        public int HerbloreRank { get; set; }
        public int HerbloreLevel { get; set; }
        public int HerbloreXp { get; set; }
        public int AgilityRank { get; set; }
        public int AgilityLevel { get; set; }
        public int AgilityXp { get; set; }
        public int ThievingRank { get; set; }
        public int ThievingLevel { get; set; }
        public int ThievingXp { get; set; }
        public int SlayerRank { get; set; }
        public int SlayerLevel { get; set; }
        public int SlayerXp { get; set; }
        public int FarmingRank { get; set; }
        public int FarmingLevel { get; set; }
        public int FarmingXp { get; set; }
        public int RunecraftRank { get; set; }
        public int RunecraftLevel { get; set; }
        public int RunecraftXp { get; set; }
        public int HunterRank { get; set; }
        public int HunterLevel { get; set; }
        public int HunterXp { get; set; }
        public int ConstructionRank { get; set; }
        public int ConstructionLevel { get; set; }
        public int ConstructionXp { get; set; }

        public Player Player { get; set; }
    }
}
