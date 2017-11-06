﻿using Assets.Models;
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
        public void Init(AttackerAIModel aiModel)
        {
            this.AIModel = aiModel;
            //this.AI = ai;
        }
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.tag == "ThrowingObject")
            {
                Destroy(collision.gameObject);
                Hit();
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
