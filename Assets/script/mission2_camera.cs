using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mission2_camera : MonoBehaviour
{
    public GameObject message; //종목 로고 이미지
    public bool canMove;
    private RaycastHit hit; //마우스에 클릭된 객체
    
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        clickCheck();
        
    }
    void clickCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("npc"))
                {
                    if (message.activeSelf)
                    {
                        message.SetActive(false);
                    }
                    else
                    {
                        message.SetActive(true);
                    }
                }
                if (hit.collider.gameObject.CompareTag("clue"))
                {
                    Debug.Log("clue");
                }
            }
        }
    }
}