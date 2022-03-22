using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    [SerializeField] private float turnSpeed;

    void Update(){
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(-horizontal*turnSpeed*Vector3.up, Space.World);
    }
}
