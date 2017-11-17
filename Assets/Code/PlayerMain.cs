using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{    
    public class PlayerMain : MonoBehaviour
    {
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }
        void OnCollisionEnter(Collision collision)
        {
        }
        public void Move(float value)
        {
            var location = this.gameObject.transform.position;
            location.x = value;
            transform.position = location;
        }
    }
}
