using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission1_end : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject button;

    public GameObject button2;

    public GameObject hwang;
    int flag = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonCliked()
    {
        button2.SetActive(false);
        hwang.SetActive(true);
        switch (flag)
        {
            case 1:
                t1.SetActive(false);
                t2.SetActive(true);
                flag++;
                break;
            case 2:
                t2.SetActive(false);
                t3.SetActive(true);
                flag++;
                break;
            case 3:
                t3.SetActive(false);
                t4.SetActive(true);
                flag++;
                break;
            case 4:
                button.SetActive(false);
                hwang.SetActive(false);
                //staticInfo.msgING = false;
                //여기서 맵으로 씬 체인지
                flag=1;
                break;

        }
    }

}
