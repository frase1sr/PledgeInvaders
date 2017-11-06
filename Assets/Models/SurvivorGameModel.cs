using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Models
{

    public class SurvivorGameModel
    {
        public const int NumberOfObjects = 10;
        public int SpawnRate { get; set; }
        public List<PlayerModel> Players { get; set; }
        public List<GameObject> Objects { get; set; }

        public int MapLength { get; set; }
        public int MapWidth { get; set; }
        public SurvivorGameModel()
        {
            SpawnRate = 1;
            Players = new List<PlayerModel>();
            this.MapWidth = 50;
            this.MapLength = 50;

        }
    }

}
