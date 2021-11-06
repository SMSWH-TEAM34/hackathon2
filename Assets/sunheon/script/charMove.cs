using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    Vector3 lookDirection;
    //1 = front
    //2 = left
    //3 = right
    //4 = back
    void start()
    {
        
    }
    void Update()
    {
        if(staticInfo.msgING == false)
        {
            move();
        }
    }
    void move()
    {
        float speed = 5.0f * Time.deltaTime;
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.W)) { z = speed; }
        else if (Input.GetKey(KeyCode.S)) { z = -speed; }
        else if (Input.GetKey(KeyCode.A)) { x = -speed; }
        else if (Input.GetKey(KeyCode.D)) { x = speed; }
        transform.Translate(x, 0.0f, z);

        /*if (Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.S))
        {
            float xx = Input.GetAxisRaw("Vertical");
            float zz = Input.GetAxisRaw("Horizontal");
            lookDirection = xx * Vector3.forward + zz * Vector3.right;

            this.transform.rotation = Quaternion.LookRotation(lookDirection);
            
        }*/
    }

}
