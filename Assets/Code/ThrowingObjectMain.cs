using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    public class ThrowingObjectMain : MonoBehaviour
    {
        public Rigidbody Object;
        public float speed = 10f;
        public GameObject Player;
        void Fire()
        {
            Rigidbody objectClone = (Rigidbody)Instantiate(Object, transform.position, transform.rotation);
            objectClone.velocity = transform.forward * speed;
        }
        // Calls the fire method when holding down ctrl or mouse
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Fire();
            }
        }
    }
}
