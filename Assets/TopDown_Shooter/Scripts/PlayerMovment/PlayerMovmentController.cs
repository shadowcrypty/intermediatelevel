using System.Collections;
using System.Collections.Generic;
using TopDownShooter.UserInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovment
{


    public class PlayerMovmentController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private PlayerMovmentSettings _playerMovmentSettings;

        private void Update()
        {
            rigidbody.MovePosition(rigidbody.position+rigidbody.transform.right * _inputData.horizontal*_playerMovmentSettings.horizontalSpeed);
            rigidbody.MovePosition(rigidbody.position+rigidbody.transform.forward * _inputData.vertical*_playerMovmentSettings.verticalSpeed);
        }
    }
}