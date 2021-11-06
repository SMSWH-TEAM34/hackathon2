using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3_Rotate : MonoBehaviour
{
    public float rotateSpeed = 3f;

    void Update()
    {
        transform.Rotate(0f, -Input.GetAxis("Mouse X") * rotateSpeed, 0f, Space.World);
        //transform.Rotate(-Input.GetAxis("Mouse Y") * rotateSpeed, 0f, 0f);
    }
}
