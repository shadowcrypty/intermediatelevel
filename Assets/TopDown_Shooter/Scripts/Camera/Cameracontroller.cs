using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{


    public class Cameracontroller : MonoBehaviour
    {
        [SerializeField] private Camerasettings _camerasettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position), Time.deltaTime * _camerasettings.LerpSpeed);
        }

    }
}