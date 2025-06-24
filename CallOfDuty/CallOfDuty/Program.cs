// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using CallOfDuty;
using CallOfDuty.ConfigurationSettings;
using CallOfDuty.Models;
PlayerSettings player_Noa = new PlayerSettings
    (
        "Noa Mari",
        "MMMMM",
        new DateTime(2024, 5, 1),
        new Resolution(1920, 1080),
        15,
        new List<Weapon>
                    {
                        new Weapon ("Grenade",35),
                        new Weapon ("Sniper", 100)
                    },
        false
);
PlayerSettings player_Shahaf = new PlayerSettings
    (
        "Shahaf Efrony",
        "EEEEEE",
        new DateTime(2023, 5, 6),
        new Resolution(1230, 130),
        2000.4,
        new List<Weapon>
                    {
                        new Weapon ("Srick",0),
                        new Weapon ("Ax", 56)
                    },
        false
);
GameConfiguration config = new GameConfiguration();
config.Players.Add(player_Noa);
config.Players.Add(player_Shahaf);

string filePath = "/Users/noamari/Desktop/mamas2/callofduty/callofduty/CallOfDuty/callofduty_config.xml";
XmlConfigManager manager = new XmlConfigManager();
manager.SaveObjectToPath(config, filePath);


