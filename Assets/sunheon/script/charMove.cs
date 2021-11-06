using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    Vector3 lookDirection;
    //1 = front
    //2 = left
    //3 = back
    //4 = right

    public GameObject front;
    public GameObject left;
    public GameObject right;
    public GameObject back;

    void start()
    {
        front.SetActive(true);
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

        if (Input.GetKey(KeyCode.W)) {
            z = speed;
            front.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            back.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.S)) {
            z = -speed;
            front.SetActive(true);
            left.SetActive(false);
            right.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.A)) {
            x = -speed;
            front.SetActive(false);
            left.SetActive(true);
            right.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.D)) {
            x = speed;
            front.SetActive(false);
            left.SetActive(false);
            right.SetActive(true);
            back.SetActive(false);
        }
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
