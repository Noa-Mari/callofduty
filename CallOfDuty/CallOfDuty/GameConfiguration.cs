using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDuty
{
    public class GameConfiguration
    {

        public List<PlayerSettings> Players { get; set; }

        public GameConfiguration()
        {
            Players = new List<PlayerSettings>();
        }
        
    }
}