using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Models
{

    public class SurvivorGameModel
    {
        public int NumberOfObjects { get; set; }
        public int SpawnRate { get; set; }
        public List<GameObject> Objects { get; set; }
        public float MapLength { get; set; }
        public float MapWidth { get; set; }
        public SurvivorGameModel(int spawnRate, int numberOfObjects)
        {
            this.SpawnRate = spawnRate;
            this.NumberOfObjects = numberOfObjects;
        }
    }

}
