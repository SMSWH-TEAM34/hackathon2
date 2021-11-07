using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapCharMove : MonoBehaviour
{
    public GameObject front;
    public GameObject left;
    public GameObject right;
    public GameObject back;

    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();   
    }
    void move()
    {
        float speed = 5.0f * Time.deltaTime;
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            z = speed;
            front.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            back.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z = -speed;
            front.SetActive(true);
            left.SetActive(false);
            right.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x = -speed;
            front.SetActive(false);
            left.SetActive(true);
            right.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = speed;
            front.SetActive(false);
            left.SetActive(false);
            right.SetActive(true);
            back.SetActive(false);
        }
        transform.Translate(x, 0.0f, z);
        
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.gameObject.CompareTag("myungsin"))
        {
            Debug.Log("myungsin");
            UI.SetActive(true);
        }
    }
}
