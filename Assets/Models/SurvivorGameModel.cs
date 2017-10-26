using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Models
{

    public class SurvivorGameModel
    {
        public int SpawnRate { get; set; }
        public List<PlayerModel> Players { get; set; }
        public SurvivorGameModel()
        {
            SpawnRate = 1;
            Players = new List<PlayerModel>();
        }
    }
}
