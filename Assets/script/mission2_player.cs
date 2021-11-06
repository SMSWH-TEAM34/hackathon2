﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission2_player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameObject.Find("mission2").GetComponent<mission2_camera>().canMove)
        {
            UpdateKeyboard();
        }
    }
    private void UpdateKeyboard()
    {
        float speed = 5.0f * Time.deltaTime;
        float x = 0f;
        float z = 0f;
        
        if (Input.GetKey(KeyCode.W)) { z = speed; }
        else if (Input.GetKey(KeyCode.S)) { z = -speed; }
        else if (Input.GetKey(KeyCode.A)) { x = -speed; }
        else if (Input.GetKey(KeyCode.D)) { x = speed; }
        transform.Translate(x, 0.0f, z);
    }
}