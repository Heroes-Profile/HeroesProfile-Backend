﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ServerApplication;
//
//    var replayData = ReplayData.FromJson(jsonString);

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HeroesProfile_Backend.Models
{
    public partial class ReplayData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parsed_id")]
        public long? ParsedId { get; set; }

        [JsonProperty("filename")]
        public Guid Filename { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("game_type")]
        public string GameType { get; set; }
        public string GameType_id { get; set; }

        [JsonProperty("game_date")]
        public DateTimeOffset? GameDate { get; set; }

        [JsonProperty("game_map")]
        public string GameMap { get; set; }
        public string GameMap_id { get; set; }

        [JsonProperty("game_length")]
        public long? GameLength { get; set; }

        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        [JsonProperty("fingerprint")]
        public Guid Fingerprint { get; set; }

        [JsonProperty("region")]
        public long? Region { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("bans")]
        public string[][] Bans { get; set; }

        [JsonProperty("players")]
        public Replay_Player[] replay_Players { get; set; }
    }

    public partial class MapIDS
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        //[JsonProperty("filename")]
        //public string Filename { get; set; }

        //[JsonProperty("fingerprint")]
        //public string Fingerprint { get; set; }

        [JsonProperty("game_date")]
        public string GameDate { get; set; }

        [JsonProperty("game_length")]
        public long? GameLength { get; set; }

        [JsonProperty("game_map")]
        public string GameMap { get; set; }

        [JsonProperty("game_type")]
        public string GameType { get; set; }

        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("region")]
        public long? Region { get; set; }

        //[JsonProperty("size")]
        //public long Size { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }


    public partial class LambdaReplayData
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
        public string GameType_id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }
        public string GameMap_id { get; set; }


        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("bans")]
        public string[][] Bans { get; set; }

        [JsonProperty("players")]
        public Lambda_Player[] Lambda_Players { get; set; }
    }


    public partial class Lambda_Player
    {
        [JsonProperty("battletag_name")]
        public string BattletagName { get; set; }

        [JsonProperty("battletag_id")]
        public long BattletagId { get; set; }
        public string BattletagID { get; set; }

        [JsonProperty("blizz_id")]
        public long BlizzId { get; set; }

        [JsonProperty("account_level")]
        public long AccountLevel { get; set; }

        [JsonProperty("hero")]
        public string Hero { get; set; }
        public string Hero_id { get; set; }

        [JsonProperty("hero_level")]
        public long HeroLevel { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("winner")]
        public bool Winner { get; set; }

        [JsonProperty("silenced")]
        public bool Silenced { get; set; }

        [JsonProperty("staff")]
        public bool Staff { get; set; }

        [JsonProperty("party")]
        public long Party { get; set; }

        [JsonProperty("talents")]
        public string[] Talents { get; set; }

        [JsonProperty("score")]
        public Lambda_Score Lambda_Score { get; set; }
    }
    public partial class Lambda_Score
    {
        [JsonProperty("Level")]
        public long? Level { get; set; }

        [JsonProperty("Takedowns")]
        public long? Takedowns { get; set; }

        [JsonProperty("SoloKills")]
        public long? SoloKills { get; set; }

        [JsonProperty("Assists")]
        public long? Assists { get; set; }

        [JsonProperty("Deaths")]
        public long? Deaths { get; set; }

        [JsonProperty("HighestKillStreak")]
        public long? HighestKillStreak { get; set; }

        [JsonProperty("HeroDamage")]
        public long? HeroDamage { get; set; }

        [JsonProperty("SiegeDamage")]
        public long? SiegeDamage { get; set; }

        [JsonProperty("StructureDamage")]
        public long? StructureDamage { get; set; }

        [JsonProperty("MinionDamage")]
        public long? MinionDamage { get; set; }

        [JsonProperty("CreepDamage")]
        public long? CreepDamage { get; set; }

        [JsonProperty("SummonDamage")]
        public long? SummonDamage { get; set; }

        [JsonProperty("TimeCCdEnemyHeroes")]
        public TimeSpan? TimeCCdEnemyHeroes { get; set; }

        [JsonProperty("Healing")]
        public long? Healing { get; set; }

        [JsonProperty("SelfHealing")]
        public long? SelfHealing { get; set; }

        [JsonProperty("DamageTaken")]
        public long? DamageTaken { get; set; }

        [JsonProperty("ExperienceContribution")]
        public long? ExperienceContribution { get; set; }

        [JsonProperty("TownKills")]
        public long? TownKills { get; set; }

        [JsonProperty("TimeSpentDead")]
        public TimeSpan? TimeSpentDead { get; set; }

        [JsonProperty("MercCampCaptures")]
        public long? MercCampCaptures { get; set; }

        [JsonProperty("WatchTowerCaptures")]
        public long? WatchTowerCaptures { get; set; }

        [JsonProperty("MetaExperience")]
        public long? MetaExperience { get; set; }

        [JsonProperty("ProtectionGivenToAllies")]
        public long? ProtectionGivenToAllies { get; set; }

        [JsonProperty("TimeSilencingEnemyHeroes")]
        public long? TimeSilencingEnemyHeroes { get; set; }

        [JsonProperty("TimeRootingEnemyHeroes")]
        public long? TimeRootingEnemyHeroes { get; set; }

        [JsonProperty("TimeStunningEnemyHeroes")]
        public long? TimeStunningEnemyHeroes { get; set; }

        [JsonProperty("ClutchHealsPerformed")]
        public long? ClutchHealsPerformed { get; set; }

        [JsonProperty("EscapesPerformed")]
        public long? EscapesPerformed { get; set; }

        [JsonProperty("VengeancesPerformed")]
        public long? VengeancesPerformed { get; set; }

        [JsonProperty("OutnumberedDeaths")]
        public long? OutnumberedDeaths { get; set; }

        [JsonProperty("TeamfightEscapesPerformed")]
        public long? TeamfightEscapesPerformed { get; set; }

        [JsonProperty("TeamfightHealingDone")]
        public long? TeamfightHealingDone { get; set; }

        [JsonProperty("TeamfightDamageTaken")]
        public long? TeamfightDamageTaken { get; set; }

        [JsonProperty("TeamfightHeroDamage")]
        public long? TeamfightHeroDamage { get; set; }

        [JsonProperty("Multikill")]
        public long? Multikill { get; set; }

        [JsonProperty("PhysicalDamage")]
        public long? PhysicalDamage { get; set; }

        [JsonProperty("SpellDamage")]
        public long? SpellDamage { get; set; }

        [JsonProperty("MatchAwards")]
        public long[] MatchAwards { get; set; }
    }


    public partial class LambdaReplayData
    {
        public static LambdaReplayData FromJson(string json) => JsonConvert.DeserializeObject<LambdaReplayData>(json, Converter.Settings);
    }

    public partial class MapIDS
    {
        public static MapIDS[] FromJson(string json) => JsonConvert.DeserializeObject<MapIDS[]>(json, Converter.Settings);
    }
    public partial class Replay_Player
    {
        //MMR Data
        public double player_conservative_rating { get; set; }
        public double player_mean { get; set; }
        public double player_standard_deviation { get; set; }

        public double role_conservative_rating { get; set; }
        public double role_mean { get; set; }
        public double role_standard_deviation { get; set; }

        public double hero_conservative_rating { get; set; }
        public double hero_mean { get; set; }
        public double hero_standard_deviation { get; set; }

        public string player_league_tier { get; set; }
        public string hero_league_tier { get; set; }
        public string role_league_tier { get; set; }

        [JsonProperty("hero")]
        public string Hero { get; set; }
        public string Hero_id { get; set; }

        public string Role { get; set; }

        [JsonProperty("hero_level")]
        public long HeroLevel { get; set; }
        public long MasteryTaunt { get; set; }
        public long Mirror { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("winner")]
        public bool Winner { get; set; }

        public string WinnerValue { get; set; }

        [JsonProperty("blizz_id")]
        public long BlizzId { get; set; }

        [JsonProperty("party")]
        public long? Party { get; set; }

        //[JsonProperty("silenced")]
        //public bool? Silenced { get; set; }

        [JsonProperty("battletag")]
        public string Battletag { get; set; }

        public string BattletagID { get; set; }

        [JsonProperty("talents")]
        public Dictionary<string, string> Talents { get; set; }

        [JsonProperty("score")]
        public Dictionary<string, long?> Score { get; set; }
    }

    public partial class ReplayData
    {
        public static ReplayData[] FromJson(string json) => JsonConvert.DeserializeObject<ReplayData[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ReplayData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
