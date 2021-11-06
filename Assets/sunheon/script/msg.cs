using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msg : MonoBehaviour
{
    public GameObject txt0;
    public GameObject txt1;
    public GameObject txt2;
    public GameObject txt3;
    public GameObject txt4;
    public GameObject txt5;
    public GameObject txt6;
    public GameObject txt7;
    public GameObject txt8;
    public GameObject txt9;
    public GameObject ui;
    public GameObject Button;
    public GameObject plate;

    public GameObject re;

    public GameObject hwang;
    public GameObject main;

    public GameObject missionUI;

    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        txt0.SetActive(true);
        mainChar();
        main.SetActive(true);
        ui.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton()
    {
       
        switch (staticInfo.msgnumber)
        {
            case 0:
                txt0.SetActive(false);
                txt1.SetActive(true);
                hwangChar();
                staticInfo.msgnumber++;
                break;
            case 1:
                if (flag == false)
                {
                    txt1.SetActive(false);
                    txt2.SetActive(true);
                    mainChar();
                    ui.SetActive(false);
                    
                    staticInfo.msgnumber++;
                    flag = true;
                    staticInfo.msgING = false;
                    break;
                }
                break;
            case 2:
                txt2.SetActive(false);
                txt3.SetActive(true);
                hwangChar();
                staticInfo.msgnumber++;
                break;
            case 3:
                txt3.SetActive(false);
                txt4.SetActive(true);
                mainChar();
                staticInfo.msgnumber++;
                break;
            case 4:
                txt4.SetActive(false);
                txt5.SetActive(true);
                hwangChar();
                staticInfo.msgnumber++;
                break;
            case 5:
                txt5.SetActive(false);
                txt6.SetActive(true);
                mainChar();
                staticInfo.msgnumber++;
                break;
            case 6:
                txt6.SetActive(false);
                txt7.SetActive(true);
                hwangChar();
                staticInfo.msgnumber++;
                break;
            case 7:
                txt7.SetActive(false);
                txt8.SetActive(true);
                staticInfo.msgnumber++;
                break;
            case 8:
                txt8.SetActive(false);
                txt9.SetActive(true);
                staticInfo.msgnumber++;
                break;
            case 9:
                CharFalse();
                txt9.SetActive(false);
                Button.SetActive(false);
                missionUI.SetActive(true);
                plate.SetActive(true);
                staticInfo.mission = 1;
                staticInfo.msgING = false;
                staticInfo.msgnumber++;
                break;
        }
        
    }
    private void mainChar()
    {
        main.SetActive(true);
        hwang.SetActive(false);
    }
    private void hwangChar()
    {
        main.SetActive(false);
        hwang.SetActive(true);
    }
    private void CharFalse()
    {
        main.SetActive(false);
        hwang.SetActive(false);
    }
}
