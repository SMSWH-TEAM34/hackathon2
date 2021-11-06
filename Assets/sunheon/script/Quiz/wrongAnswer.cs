using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongAnswer : MonoBehaviour
{
    public GameObject wrong;
    public GameObject nowQ;
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
        wrong.SetActive(true);
        nowQ.SetActive(false);
    }
}
