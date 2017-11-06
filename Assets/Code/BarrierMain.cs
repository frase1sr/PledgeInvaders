using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    public class BarrierMain : MonoBehaviour
    {
        public BarrierModel BarrierModel { get; set; }
        public void Init(BarrierModel model)
        {
            this.BarrierModel = model;

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
            if (this.BarrierModel.Health == 1)
            {
                Destroy(this.gameObject);
            }
            else
            {
                this.BarrierModel.Health--;
            }
        }

    }
}
