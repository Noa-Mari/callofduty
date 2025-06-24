using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDuty.ConfigurationSettings
{
     public class PlayerSettings
    {
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public DateTime JoinDate { get; set; }
        public Resolution PreferredResolution { get; set; }
        public double AverageKillsPerDay { get; set; }
        public List<Weapon> FavoriteWeapons { get; set; }

        [XmlIgnore]
        public bool IsCheater { get; set; }

        public PlayerSettings(string fullName, string nickname, DateTime joinDate, Resolution resolution, double killsPerDay, List<Weapon> weapons, bool isCheater)
        {
            FullName = fullName;
            Nickname = nickname;
            JoinDate = joinDate;
            PreferredResolution = resolution;
            AverageKillsPerDay = killsPerDay;
            FavoriteWeapons = weapons ?? new List<Weapon>();
            IsCheater = isCheater;
        }
        public PlayerSettings()
        {
            FavoriteWeapons = new List<Weapon>();
            PreferredResolution = new Resolution();
        }

        
    }
}