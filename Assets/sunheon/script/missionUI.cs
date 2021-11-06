using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionUI : MonoBehaviour
{
    public GameObject missionInfo;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickMission()
    {
        if(flag == false)
        {
            missionInfo.SetActive(true);
            flag = true;
            
        }
        else
        {
            missionInfo.SetActive(false);
            flag = false;
            
        }
        
    }
}
