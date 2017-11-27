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
        public float Health { get; set; }
        public decimal Speed { get; set; }
        public int Damage { get; set; }
        public bool IsDead { get; set; }

    }
    public class SurvivalPlayerModel : PlayerModel
    {

        public SurvivalPlayerModel()
        {
            this.Speed = 100;
            this.Damage = 100;
        }
    }
    public class AttackerPlayerModel : PlayerModel
    {

    }
    public class AttackerAIModel : AttackerPlayerModel
    {

        private const int EasySpeed = 1;
        private const int MediumSpeed = 2;
        private const int HardSpeed = 3;
        private const int EasyDamage = 10;
        private const int MediumDamage = 10;
        private const int HardDamage = 10;
        private const int EasyHealth = 1;
        private const int MediumHealth = 2;
        private const int HardHealth = 3;

        public float DamageDelaySeconds { get; set; }

        public AttackerAIModel(AIType type)
        {
            this.Type = type;
            switch (type)
            {
                case AIType.Easy:
                    this.Speed = EasySpeed;
                    this.Damage = EasyDamage;
                    this.Health = EasyHealth;
                    this.DamageDelaySeconds = 2;
                    break;
                case AIType.Medium:
                    this.Speed = MediumSpeed;
                    this.Damage = MediumDamage;
                    this.Health = MediumHealth;
                    this.DamageDelaySeconds = 2;
                    break;
                case AIType.Hard:
                    this.Speed = HardSpeed;
                    this.Damage = HardDamage;
                    this.Health = HardHealth;
                    this.DamageDelaySeconds = 2;
                    break;
            }
        }
        public AIType Type { get; set; }
    }






}



