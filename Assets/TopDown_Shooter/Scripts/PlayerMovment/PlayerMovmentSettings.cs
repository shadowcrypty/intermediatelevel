using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovment
{


    [CreateAssetMenu(menuName = "TopDownShooter/Player/MovmentSettings")]
    public class PlayerMovmentSettings : ScriptableObject
    {
        public float horizontalSpeed=5;
        public float verticalSpeed=5;
    }
}