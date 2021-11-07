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
    public GameObject newspaper2;
    public GameObject album;
    public GameObject cats;
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
    public Text catMsg;
    public GameObject player;
    public int idx = -1;

    private RaycastHit hit; //마우스에 클릭된 객체
    private string[] hi = { "충성!",
        "만나서 정말 반갑다!",
        "이렇게 날 오래 기다리게 하면 어떡합니까!",
        "내 이름을 맞추면 집으로 보내드리겠습니다!"
    };
    private string[] wrong = { "...", "땡! 틀렸습니다!", "다시 한번 잘 살펴봅니다!" };
    private string[] correct = { "...", "정답이다", "역시 숙명인! 이렇게 빨리 찾아낼줄은..!!",
                            "약속대로 집에 보내드리겠습니다!",
                            "순헌 황귀비님께서 돌려보내 주실 겁니다! 만나서 반가웠다!",
                            "순헌 황귀비님~~!!" };
    private string[] catmsgs = { "안녕 나는 태평이야~", "츄르 있어?"};

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
                        player.GetComponent<m3_move>().canMove = false;
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
                    player.GetComponent<m3_move>().canMove = false;
                }
                if (obj.name == "Letter")
                {
                    letter.SetActive(true);
                    player.GetComponent<m3_move>().canMove = false;
                }
                if(obj.name == "mission")
                {
                    inputfield.SetActive(true);
                    button.SetActive(true);
                    player.GetComponent<m3_move>().canMove = false;
                }
                if (obj.name == "NewsPaper2")
                {
                    newspaper2.SetActive(true);
                    player.GetComponent<m3_move>().canMove = false;
                }
                if (obj.name == "Album")
                {
                    album.SetActive(true);
                    player.GetComponent<m3_move>().canMove = false;
                }
                if (obj.name == "Cat")
                {
                    idx = 0;
                    cats.SetActive(true);
                    player.GetComponent<m3_move>().canMove = false;
                    
                }


            }

        }
    }

    public void tryAnswer()
    {
        inputfield.SetActive(true);
        button.SetActive(true);
        player.GetComponent<m3_move>().canMove = false;
    }
    public void checkAnswer()
    {
        Debug.Log(inputfieldd.text);
        inputfield.SetActive(false);
        button.SetActive(false);

        if (inputfieldd.text == "박기은")
        {
            correctAnswer();
        }
        else
        {
            wrongAnswer();
        }
    }

    public void wrongAnswer()
    {
        idx = 0;

        if (!wrongMsg.activeSelf)
        {
            player.GetComponent<m3_move>().canMove = false;
            wrongMsg.SetActive(true);
        }
    }

    public void correctAnswer()
    {
        idx = 0;
        if (!correctMsg.activeSelf)
        {
            player.GetComponent<m3_move>().canMove = false;
            correctMsg.SetActive(true);
        }
    }

    public void nextcatMsg()
    {
        
        if (idx+1 <= catmsgs.Length)
        {
            Debug.Log(idx);
            catMsg.text = catmsgs[idx];
            idx++;

        }
        else
        {
            player.GetComponent<m3_move>().canMove = true;
            cats.SetActive(false);
        }
    }

    public void nextMsg()
    {

        if (idx+1 < hi.Length)
        {
            idx++;
            msg.text = hi[idx];
            
        }
        else 
        {
            player.GetComponent<m3_move>().canMove = true;
            panel.SetActive(false);
            panel1.SetActive(true);
            missionMsg.text = "이름 맞추기";
        }  
    }

    public void nextWrongMsg()
    {
        Debug.Log(idx);

       if(idx+1 < wrong.Length)
        {
            idx++;
            wrongMsgg.text = wrong[idx];
        }
        else
        {
            player.GetComponent<m3_move>().canMove = true;
            wrongMsg.SetActive(false);

        }
    }

    public void nextCorrectMsg()
    {
        Debug.Log(idx);

        if (idx < correct.Length)
        {
            correctMsgg.text = correct[idx++];
        }
        else
        {
            correctMsg.SetActive(false);
            //이후에 다음씬 이동 등을 정의...-----------------------------------!!!
        }
    }
  
}
