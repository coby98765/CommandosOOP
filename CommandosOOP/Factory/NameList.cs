using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandosOOP.Models;


namespace CommandosOOP.Models
    {
    internal static class NameList
        {
        public static string[] EnemiesName = new string[10]
            {
                "Thanos",
                "Loki",
                "Green Goblin",
                "Ultron",
                "Doctor Octopus",
                "Red Skull",
                "Kingpin",
                "Killmonger",
                "Venom",
                "Hela"
            };
        public static List<Dictionary<string, string>> CommandosNames = new List<Dictionary<string, string>>
            {
             new Dictionary<string, string>
                {
                    { "name", "Tony Stark" },
                    { "nickname", "Iron Man" },
                    { "type", "air" }
                },
             new Dictionary<string, string>
                {
                    { "name", "Steve Rogers" },
                    { "nickname", "Captain America" },
                    { "type", "land" }
                },
             new Dictionary<string, string>
                {
                    { "name", "Thor Odinson" },
                    { "nickname", "Thor" },
                    { "type", "air" }
                },
             new Dictionary<string, string>
                {
                    { "name", "Bruce Banner" },
                    { "nickname", "Hulk" },
                    { "type", "land" }
                },
             new Dictionary<string, string>
                {
                    { "name", "Natasha Romanoff" },
                    { "nickname", "Black Widow" },
                    { "type", "land" }
                },
             new Dictionary<string, string>
                {
                    { "name", "T'Challa" },
                    { "nickname", "Black Panther" },
                    { "type", "land" }
                },
             new Dictionary<string, string>
    {
        { "name", "Peter Parker" },
        { "nickname", "Spider-Man" },
        { "type", "air" }
    },
    new Dictionary<string, string>
    {
        { "name", "Stephen Strange" },
        { "nickname", "Doctor Strange" },
        { "type", "air" }
    },
    new Dictionary<string, string>
    {
        { "name", "Carol Danvers" },
        { "nickname", "Captain Marvel" },
        { "type", "air" }
    },
    new Dictionary<string, string>
    {
        { "name", "Namor" },
        { "nickname", "Sub-Mariner" },
        { "type", "sea" }
    }
};
        public static List<Dictionary<string, object>> weaponDataList = new List<Dictionary<string, object>>
            {
    new Dictionary<string, object>
    {
        { "type", "knife" },
        { "name", "Silent Fang" },
        { "maker", "Wakandan Forge" },
        { "strength", 60 },
        { "health", 80 },
        { "color", "Silver" },
        { "weight", 1.3 },
        { "maxHits", 5 }
    },
    new Dictionary<string, object>
    {
        { "type", "gun" },
        { "name", "Blaster" },
        { "maker", "Stark Industries" },
        { "strength", 100 },
        { "health", 100 },
        { "color", "Red" },
        { "weight", 4.2 },
        { "maxBullets", 12 }
    },
    new Dictionary<string, object>
    {
        { "type", "knife" },
        { "name", "Shadow Dagger" },
        { "maker", "Hydra Labs" },
        { "strength", 45 },
        { "health", 60 },
        { "color", "Black" },
        { "weight", 1.1 },
        { "maxHits", 4 }
    },
    new Dictionary<string, object>
    {
        { "type", "gun" },
        { "name", "Pulse Rifle" },
        { "maker", "S.H.I.E.L.D." },
        { "strength", 90 },
        { "health", 95 },
        { "color", "Blue" },
        { "weight", 3.7 },
        { "maxBullets", 30 }
    }
};
        }
    }
