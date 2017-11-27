using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{    
    public class AIMain : MonoBehaviour
    {
        public AttackerAIModel AIModel { get; set; }
        private float Timer = 0f;
        private bool IsDamaging = false;
        private GameObject player;
        public void Init(AttackerAIModel aiModel)
        {
            this.AIModel = aiModel;
        }
        // Use this for initialization
        void Start()
        {
                player = GameObject.FindWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            if (IsDamaging)
            {
                Timer += Time.deltaTime;
                if (Timer >= this.AIModel.DamageDelaySeconds)
                {
                    Timer = 0f;
                    player.GetComponent<PlayerMain>().TakeDamage(AIModel.Damage);
                }
            }
        }
        void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.tag == "ThrowingObject")
            {
                Destroy(collision.gameObject);
                Hit();
            }
            if (collision.gameObject.tag == "PlayerBarrier")
            {
                IsDamaging = true;
            }
        }
        private void Hit()
        {
            if (this.AIModel.Health == 1)
            {
                Destroy(this.gameObject);
              
            }
            else
            {
                this.AIModel.Health--;
            }
        }

    }
}
