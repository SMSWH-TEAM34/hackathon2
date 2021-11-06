using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextQuiz : MonoBehaviour
{
    public GameObject nowQ;
    public GameObject nextQ;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnbuttonClickd()
    {
        //staticInfo.msgING = true;
        button.SetActive(false);
        nowQ.SetActive(false);
        nextQ.SetActive(true);
    }
}
