using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Models
{
    public enum AIType
    {
        Easy,
        Medium,
        Hard
    }
    public class PlayerModel
    {
        public GameObject PlayerObject { get; set; }
        public decimal Health { get; set; }
        public decimal Speed { get; set; }
        public decimal DamageMultiplier { get; set; }
        public PlayerModel()
        {
            Health = 100;
        }

    }
    public class SurvivalPlayerModel : PlayerModel
    {

        public SurvivalPlayerModel()
        {
            this.Speed = 100;
            this.DamageMultiplier = 100;
        }
    }
    public class AttackerPlayerModel : PlayerModel
    {

    }
    public class AttackerAIModel : AttackerPlayerModel
    {

        public const int EasySpeed = 1;
        public const int MediumSpeed = 2;
        public const int HardSpeed = 3;
        public const int EasyDamageMultiplier = 1;
        public const int MediumDamageMultiplier = 2;
        public const int HardDamageMultiplier = 3;
        public const int EasyHealth = 1;
        public const int MediumHealth = 2;
        public const int HardHealth = 3;

        public AttackerAIModel(AIType type)
        {
            this.Type = type;
            switch (type)
            {
                case AIType.Easy:
                    this.Speed = EasySpeed;
                    this.DamageMultiplier = EasyDamageMultiplier;
                    this.Health = EasyHealth;
                    break;
                case AIType.Medium:
                    this.Speed = MediumSpeed;
                    this.DamageMultiplier = MediumDamageMultiplier;
                    this.Health = MediumHealth;

                    break;
                case AIType.Hard:
                    this.Speed = HardSpeed;
                    this.DamageMultiplier = HardDamageMultiplier;
                    this.Health = HardHealth;
                    break;
            }
        }
        public AIType Type { get; set; }
    }






}



