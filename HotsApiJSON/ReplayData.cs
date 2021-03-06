﻿using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HotsApiJSON
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

        [JsonProperty("game_date")]
        public DateTimeOffset GameDate { get; set; }

        [JsonProperty("game_map")]
        public string GameMap { get; set; }

        [JsonProperty("game_length")]
        public long GameLength { get; set; }

        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        [JsonProperty("fingerprint")]
        public Guid Fingerprint { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

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
    }


    public partial class ReplayData
    {
        public static ReplayData[] FromJson(string json) => JsonConvert.DeserializeObject<ReplayData[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ReplayData[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
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