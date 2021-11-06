using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_msg : MonoBehaviour
{
    public GameObject nowmsg;
    public GameObject nextmsg;
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
        Debug.Log("finish");
        Application.Quit();
    }
}
