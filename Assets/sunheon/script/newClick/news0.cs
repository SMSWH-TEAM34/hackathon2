using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class news0 : MonoBehaviour
{
    public GameObject news1;
    public GameObject news2;
    public GameObject news3;
    public GameObject news4;
    public GameObject news5;
    public GameObject news6;

    public GameObject newsS;

    public GameObject exitB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        staticInfo.msgING = true;
        exitB.SetActive(true);
        newsS.SetActive(true);
        news1.SetActive(true);
        news2.SetActive(false);
        news3.SetActive(false);
        news4.SetActive(false);
        news5.SetActive(false);
        news6.SetActive(false);
    }
}
