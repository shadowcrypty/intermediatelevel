using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesssons
{

    [CreateAssetMenu(menuName ="Lessons/RotateSettings")]
    
    public class rotatesettings : ScriptableObject
    {
        [SerializeField] public float _speed;
        public float Speed { get { return _speed; }  }


    }
}