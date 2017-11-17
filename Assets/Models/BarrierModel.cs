using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Models
{
    public class BarrierModel
    {
        public int Health { get; set; }
        public int Type { get; set; }
        public BarrierModel(int health, int type)
        {
            this.Health = health;
            this.Type = type;   
        }
    }
}
