using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_msg : MonoBehaviour
{
    public GameObject nowmsg;
    public GameObject nextmsg;

    public GameObject hwang;
    public GameObject sook;
    public GameObject canvas;
    public GameObject finishUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclickedmsg()
    {
        nowmsg.SetActive(false);
        nextmsg.SetActive(true);
    }

    public void OnclickExit()
    {
        
        hwang.SetActive(false);
        canvas.SetActive(false);
        sook.SetActive(true);
        finishUI.SetActive(true);


    }
}
