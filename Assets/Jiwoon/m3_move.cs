using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m3_move : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    Vector3 lookDirection;
    //1 = front
    //2 = left
    //3 = back
    //4 = right

    public GameObject Front;
    public GameObject Left;
    public GameObject Right;
    public GameObject Back;
    public bool canMove;

    void start()
    {
        Front.SetActive(true);
        canMove = true;
    }
    void Update()
    {
        if (canMove) move();
    }
    void move()
    {
        float speed = 5.0f * Time.deltaTime;
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            z = -speed;
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
            Back.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z = speed;
            Front.SetActive(true);
            Left.SetActive(false);
            Right.SetActive(false);
            Back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x = speed;
            Front.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);
            Back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = -speed;
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);
            Back.SetActive(false);
        }
        transform.Translate(x, 0.0f, z);

     
    }

}
