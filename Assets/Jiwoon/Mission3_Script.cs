using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mission3_Script : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel1;
    public GameObject newspaper;
    public GameObject letter;
    public GameObject inputfield;
    public InputField inputfieldd;
    public GameObject button;
    public GameObject wrongMsg;
    public Text wrongMsgg;
    public GameObject correctMsg;
    public Text correctMsgg;
    public Text msg;
    public Text missionMsg;
    public GameObject player;
    public int idx = -1;

    private RaycastHit hit; //마우스에 클릭된 객체
    private string[] script = { "충성!",
        "송이야 만나서 반가워~",
        "널 기다라고 있었어",
        "내 이름을 맞추면 네가 필요로 하는 걸 줄게!"
    };
    private string[] wrong = { "...", "땡! 틀렸어", "다시 한번 잘 살펴봐" };
    private string[] correct = { "...", "정답이야", "자 이걸 가지고 가렴" };


    // Update is called once per frame
    void FixedUpdate()
    {
        clickCheck();
        clickCheck2();
    }

    void clickCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;

                if (obj.CompareTag("npc"))
                {
                    Debug.Log("npc");
                    if (!panel.activeSelf)
                    {
                        player.GetComponent<Mission3_CharacterControl>().canMove = false;
                        panel.SetActive(true);
                    }
                }

            }
        }

    }

    void clickCheck2()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;

                if (obj.name == "NewsPaper")
                {
                    newspaper.SetActive(true);
                    player.GetComponent<Mission3_CharacterControl>().canMove = false;
                }
                if (obj.name == "Letter")
                {
                    letter.SetActive(true);
                    player.GetComponent<Mission3_CharacterControl>().canMove = false;
                }
                if(obj.name == "mission")
                {
                    Debug.Log("click mission");
                    inputfield.SetActive(true);
                    button.SetActive(true);
                    player.GetComponent<Mission3_CharacterControl>().canMove = false;
                }

            }

        }
    }

    public void tryAnswer()
    {
        Debug.Log("click mission");
        inputfield.SetActive(true);
        button.SetActive(true);
        player.GetComponent<Mission3_CharacterControl>().canMove = false;
    }
    public void checkAnswer()
    {
        Debug.Log(inputfieldd.text);
        inputfield.SetActive(false);
        button.SetActive(false);

        if (inputfieldd.text == "박기은")
        {
            //correctmsg active
            correctAnswer();
        }
        else
        {
            //wrong msg panel activ
            wrongAnswer();
        }
    }

    public void wrongAnswer()
    {
        idx = 0;

        if (!wrongMsg.activeSelf)
        {
            player.GetComponent<Mission3_CharacterControl>().canMove = false;
            wrongMsg.SetActive(true);
        }
    }

    public void correctAnswer()
    {
        idx = 0;
        if (!correctMsg.activeSelf)
        {
            player.GetComponent<Mission3_CharacterControl>().canMove = false;
            correctMsg.SetActive(true);
        }
    }

    public void nextMsg()
    {
        idx++;

        if (idx < 4)
        {
            msg.text = script[idx];
        }
        else 
        {
            panel.SetActive(false);
            panel1.SetActive(true);
            missionMsg.text = "이름 맞추기";
            player.GetComponent<Mission3_CharacterControl>().canMove = true;
        }  
    }

    public void nextWrongMsg()
    {
        Debug.Log(idx);

       if(idx < 3)
        {
            wrongMsgg.text = wrong[idx++];
        }
        else
        {
            wrongMsg.SetActive(false);
        }
    }

    public void nextCorrectMsg()
    {
        Debug.Log(idx);

        if (idx < 3)
        {
            correctMsgg.text = correct[idx++];
        }
        else
        {
            correctMsg.SetActive(false);
            //이후에 다음씬 이동 등을 정의...
        }
    }
  
}
