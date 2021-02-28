using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{


    public class Cameracontroller : MonoBehaviour
    {
        [SerializeField] private Camerasettings _camerasettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            CameraMovmentFollow();
            CameraRotationFollow();
        }


        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position), Time.deltaTime * _camerasettings.LerpSpeed);

        }

        private void CameraMovmentFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _targetTransform.position + _camerasettings.PosOffset, Time.deltaTime * _camerasettings.PosLerpSpeed);
        }
    }
}