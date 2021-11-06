using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holePlate : MonoBehaviour
{
    public GameObject plate;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickPlate()
    {
        if (flag == false)
        {
            plate.SetActive(true);
            flag = true;

        }
        else
        {
            plate.SetActive(false);
            flag = false;

        }

    }
}
