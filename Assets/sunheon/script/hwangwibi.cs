using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hwangwibi : MonoBehaviour
{
    public GameObject ui;

    public GameObject re;
    private bool reFlag = true;
    public GameObject txt9;
    public GameObject button;

    public GameObject hwang;
    public GameObject main;
    
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
        if (staticInfo.mission == 0)
        {
            ui.SetActive(true);
            staticInfo.msgING=true;
        }
        if (staticInfo.mission == 1 && staticInfo.missionDone == false)
        {
            if (reFlag)
            {
                reFlag = false;
                ui.SetActive(true);
                hwang.SetActive(true);
                re.SetActive(true);
                txt9.SetActive(false);
            }
            else
            {
                staticInfo.msgING = false;
                CharFalse();
                button.SetActive(false);
                reFlag = true;
            }

        }
    }
    private void CharFalse()
    {
        main.SetActive(false);
        hwang.SetActive(false);
    }
}
