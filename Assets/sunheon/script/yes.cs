using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public GameObject nono;
    public GameObject yesyes;
    public GameObject button;
    public GameObject hwang;
    public GameObject charr;


    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickYES()
    {
        button.SetActive(false);
        nono.SetActive(false);
        yesyes.SetActive(false);
        start.SetActive(true);
        hwang.SetActive(true);
        charr.SetActive(false);
    }
}
