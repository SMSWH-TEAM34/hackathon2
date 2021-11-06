using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeNews : MonoBehaviour
{
    public GameObject news;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickedNews()
    {
        staticInfo.msgING = false;
        news.SetActive(false);
    }
}
