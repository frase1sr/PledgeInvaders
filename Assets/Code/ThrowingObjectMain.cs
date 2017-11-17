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
        public float speed;
        private bool isEnabled = true;
        public void setEnabled(bool value)
        {
           this.isEnabled = value;
        }
        void Fire()
        {
            Rigidbody objectClone = (Rigidbody)Instantiate(Object, transform.position, transform.rotation);
            objectClone.velocity = transform.forward * speed;
        }
        void Update()
        {
            if (Input.GetMouseButtonDown(0) && isEnabled)
            {
                Fire();
            }
        }
    }
}
