using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalAnswer : MonoBehaviour
{
    public GameObject wrong;
    public GameObject hwang;
    public GameObject fin;
    
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
        wrong.SetActive(false);
        hwang.SetActive(false);
        fin.SetActive(true);
        
    }
}
