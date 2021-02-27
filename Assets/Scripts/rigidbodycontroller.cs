using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesssons
{


    public class rigidbodycontroller : MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private rigidbodysettings rigidbodysettings;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(rigidbodysettings.JumpForce,ForceMode.Impulse);

            }
        }
    }
}