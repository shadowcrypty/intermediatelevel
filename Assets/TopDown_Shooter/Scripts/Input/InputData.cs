using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.UserInput
{

    [CreateAssetMenu(menuName = "TopDownShooter/Input/InputData")]
    public class InputData : ScriptableObject
    {
        public float horizontal;
        public float vertical;

    }
}