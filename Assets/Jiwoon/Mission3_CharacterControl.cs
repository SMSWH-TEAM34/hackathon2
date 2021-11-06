using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3_CharacterControl : MonoBehaviour
{

    public float moveSpeed = 3.0f;
    public bool canMove = true;

    void Start()
    {

    }

    void Update()
    {
        //if (canMove)
        //{
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A");
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D");
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("W");
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("S");
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
        //}
    }



}
