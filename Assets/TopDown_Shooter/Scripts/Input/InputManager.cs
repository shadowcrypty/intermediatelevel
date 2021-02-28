﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.UserInput
{

public class InputManager : MonoBehaviour
{
        [SerializeField] private InputData _inputData;

        void Update()
        {
            _inputData.horizontal = Input.GetAxis("Horizontal");

            _inputData.vertical= Input.GetAxis("Vertical");
        }
}

}