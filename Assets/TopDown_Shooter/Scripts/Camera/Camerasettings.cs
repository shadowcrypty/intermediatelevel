using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{

    [CreateAssetMenu(menuName = "TopDownShooter/Camera/CameraSettings")]
    public class Camerasettings : ScriptableObject
    {
        [SerializeField] public float _lerpSpeed;
        public float LerpSpeed { get { return _lerpSpeed; } }
    }
}