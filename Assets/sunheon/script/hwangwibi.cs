using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hwangwibi : MonoBehaviour
{
    public GameObject ui;

    public GameObject answer;
    public GameObject txt9;
    public GameObject button;

    public GameObject hwang;
    public GameObject main;
    public GameObject nono;
    public GameObject yesyes;
    
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
            
                ui.SetActive(true);
                button.SetActive(true);
            yesyes.SetActive(true);
            nono.SetActive(true);
                hwang.SetActive(true);
            answer.SetActive(true);
                txt9.SetActive(false);
            
        }
    }
    private void CharFalse()
    {
        main.SetActive(false);
        hwang.SetActive(false);
    }
}
