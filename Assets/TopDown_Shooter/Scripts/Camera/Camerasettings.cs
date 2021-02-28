using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{

    [CreateAssetMenu(menuName = "TopDownShooter/Camera/CameraSettings")]
    public class Camerasettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] public float _lerpSpeed;
        public float LerpSpeed { get { return _lerpSpeed; } }
        [Header("Position")]
        [SerializeField] public Vector3 _posoffset;
        public Vector3 PosOffset { get { return _posoffset; } }

        [SerializeField] public float _poslerpSpeed=1;
        public float PosLerpSpeed { get { return _poslerpSpeed; } }

    }
}