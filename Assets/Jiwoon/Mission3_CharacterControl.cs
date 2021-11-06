using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3_CharacterControl : MonoBehaviour
{
    /*
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 2.0f;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * moveSpeed);

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.back * rotateSpeed * mouseX);
    }
    */
    // //은 주석 입니다.
    // Vector2는 X, Y 값을 가집니다.
    // Vector3는 X, Y, Z 값을 가집니다.

    public float moveSpeed = 3.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }



}
