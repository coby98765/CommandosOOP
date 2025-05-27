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
        }
    }
