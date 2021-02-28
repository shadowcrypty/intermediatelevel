using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lesssons
{

    [CreateAssetMenu(menuName = "Lessons/RigidbodySettings")]
    public class rigidbodysettings : ScriptableObject
    {
        [SerializeField]private Vector3 _jumpforce;
        public Vector3 JumpForce { get { return _jumpforce; } }

    }
}