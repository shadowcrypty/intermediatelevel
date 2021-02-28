using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesssons
{


    public class rotateobject : MonoBehaviour
    {
        
        [SerializeField] private rotatesettings rotatesettings;
        

        private void Update()
        {
            transform.Rotate(Vector3.up, rotatesettings.Speed * Time.deltaTime);
        }
    }
}