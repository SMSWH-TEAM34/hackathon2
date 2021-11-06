using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nono : MonoBehaviour
{
    public GameObject hwang;
    public GameObject button;
    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnClickExit()
    {
        hwang.SetActive(false);
        button.SetActive(false);
        exit.SetActive(false);
    }
}