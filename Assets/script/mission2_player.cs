using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission2_player : MonoBehaviour
{
    public GameObject labWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        checkPos();
        if (GameObject.Find("cam1").GetComponent<mission2_camera>().canMove)
        {
            UpdateKeyboard();
        }
    }
    private void UpdateKeyboard()
    {
        float speed = 5.0f * Time.deltaTime;
        float x = 0f;
        float z = 0f;
        
        if (Input.GetKey(KeyCode.W)) {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 180, 0); 
            z = speed; 
        }
        else if (Input.GetKey(KeyCode.S)) {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0);
            z = -speed; 
        }
        else if (Input.GetKey(KeyCode.A)) {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 90, 0);
            x = -speed; 
        }
        else if (Input.GetKey(KeyCode.D)) {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 270, 0);
            x = speed; 
        }
        transform.Translate(x, 0.0f, z);
    }
    private void checkPos()
    {
        if (transform.position.z > -5f)
        {
            labWall.SetActive(false);
        }
        else
        {
            labWall.SetActive(true);
        }
    }
}
