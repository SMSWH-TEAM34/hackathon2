using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mission2_camera : MonoBehaviour
{
    public GameObject panel;//대화창
    public GameObject panel1;//미션창
    public GameObject panel2;//아이템창
    public Text msg;  //대화 텍스트
    public Text missionMsg;//미션 텍스트
    public Text itemMsg;//아이템 텍스트
    public Image itemImg;//아이템 이미지

    public GameObject player;
    public GameObject npc;

    public GameObject inven;
    public GameObject inven1;
    public bool canMove;
    public int idx = 0;
    private int phase = 0;
    private string curItemTag;
    private RaycastHit hit;
    private bool[] Image0 = { true, true, false, false, true, false, false };
    private bool[] Image1 = { false, false, true, false, true, true, false, false, true, false, true, true, false, false };
    private bool[] Image2 = { false, false, false, false };

    private string[] script0 = {
        "먼가 익숙한 곳 같은 데… 저 사람이 날 찾던 사람인가?",
        "저기,,실례지만 당신이 저를 찾으셨나요? 그리고 여기는 대체 어딘가요?",
        "빨리 와서 여기 좀 도와주세요",
        "네??",
        "실험 준비에 필요한 비커랑 스포이드, 보안경을 가져다 줄 수 있나요?",
        "일단 도와주고 나서 다시 물어봐야 겠다...",
    };
       
    private string[] script = { 
        "실험실에 필요한 물품들을 더 찾아주세요!",
        "실험실에 있던 물품을 찾아서 건네준다.",
        "여기요...", 
        "네 감사합니다. 잠시만요.", 
        "먼가를 급하게 하는 거 같은데..", 
        "잠시 후...",
        "덕분에 실험이 잘 마무리 됐어요.",
        "아까 뭐라고 질문하셨었죠?",
        "아 맞다. 지금 여기가 어딘가요?",
        "여기는 지금 명신관입니다.",
        "어! 우리 학교에도 명신관이 있어요! 근데 좀 달라보이는데..",
        "아무튼 집으로 가고 싶은데 방법을 좀 알려주세요!",
        "음.. 그러면 한 가지 부탁을 들어주실 수 있나요? 혈흔 검출 시약을 만들어야 되는데 필요한 시약들을 찾아주세요!",
        "혈흔 검출 시약을 만들어야 되는데 필요한 시약들을 찾아주세요!"
    };

    private string[] script1 = {
        "조제하는 데 필요한 시약이 아닌 것 같아요.",
        "찾아주셨군요! 감사합니다. 그럼...",
        "???: 여기로 와주세요!!!!",
        "이 소리는 백주년 기념관에서 들려오는 거 같아요! 한 번 가보시는게 좋을 거 같아요!!",
    };

    private string[] item = { "beaker", "magentaPotion", "greenPotion", "yellowPotion", "redPotion", "pipette", "glasses", "book1", "book2" };
    private string[] answer1 = { "beaker","pipette" };
    private string[] answer2 = { "magentaPotion", "greenPotion" };
    private Dictionary<string, GameObject> invenInfo = new Dictionary<string, GameObject>();
    private Dictionary<string, string> itemInfo = new Dictionary<string, string>(){
        { "beaker" , "약물을 계량할 때 쓰는 컵이다."},
        { "magentaPotion", "마젠타 색상의 약물이 든 플라스크이다." },
        { "greenPotion", "초록 색상의 약물이 든 플라스크이다." },
        { "yellowPotion", "노란 색상의 약물이 든 플라스크이다." },
        { "redPotion","빨간 색상의 약물이 든 플라스크이다." },
        { "pipette","약물을 옮길 때 사용하는 스포이드이다." },
        { "glasses", "실험할 때 눈을 보호해주는 보안경이다." },
        { "book1" , "국립과학수사 연구원의 보고서이다."},
        { "book2", "미대생의 서적인 거 같다." },
     };
    private GameObject slot;

    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
        canMove = false;
        startDialog();
        slot = Resources.Load("slot") as GameObject;
    }
    
    void startDialog()
    {
        panel.SetActive(true);
        msg.text = script0[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        clickCheck();
        if (canMove)
        {
            player.SetActive(false);
            npc.SetActive(false);
        }
    }
    void clickCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("npc"))
                {
                    if (!panel.activeSelf)
                    {
                        canMove = false;
                        panel.SetActive(true);
                        if (phase == 0)//첫 대화 후 들어가는 창 
                        {
                            if (checkMission())
                            {
                                msg.text = script[1];
                                idx = 1;
                                ImageOn();
                                phase = 1;
                            }
                            else
                            {
                                msg.text = script[0];
                            }
                        }
                        else// 두번째 미션 제시 후 들어가는 창 
                        {
                            if (checkMission1())
                            {
                                msg.text = script1[1];
                                idx = 1;
                                ImageOn();
                                phase = 2;
                            }
                            else
                            {
                                msg.text = script1[0];
                                ImageOn();
                            }
                        }
                    }
                }
                else
                {
                    if (invenInfo.Count > 4) { return; }
                    for (int i = 0; i < 9; i++)
                    {
                        if (hit.collider.gameObject.CompareTag(item[i]))
                        {
                            plusInven(hit.collider.gameObject);
                        }
                    }
                }
            }
        }
    }
    public void nextMsg()
    {
        if(phase == 0)//스토리 시작 상황
        {
            if (idx > 4)
            {
                msg.text = "일단 도와주고 나서 다시 물어봐야 겠다...";
                canMove = true;
                panel.SetActive(false);
                return;
            }
            msg.text = script0[++idx];
            ImageOn();
            if (idx == 5)
            {
                canMove = true;
                panel.SetActive(false);
                panel1.SetActive(true);
                missionMsg.text = "비커, 스포이드 찾아주기";
            }
        }
        else if(phase == 1)//
        {
            if (idx > 12)
            {
                msg.text = "실험실에 필요한 물품만 찾아주세요!";
                canMove = true;
                panel.SetActive(false);
                return;
            }
            msg.text = script[++idx];
            ImageOn();
            if (idx == 13)
            {
                canMove = true;
                panel.SetActive(false);
                panel1.SetActive(true);
                missionMsg.text = "혈흔 시약을 위한 재료 찾아주기";
            }
        }
        else
        {
            if (idx > 2)
            {
                msg.text = "실험실에 필요한 물품만 찾아주세요!";
                canMove = true;
                panel.SetActive(false);
                return;
            }
            msg.text = script1[++idx];
            ImageOn();
            if (idx == 3)
            {
                canMove = true;
                panel.SetActive(false);
                panel1.SetActive(true);
                //SceneManager.LoadScene(worldMap3);
            }
        }
    }
    public bool checkMission() {
        for (int i = 0; i < 2; i++) {
            bool tmp = invenInfo.ContainsKey(answer1[i]);
            if (!tmp)
            {
                return false;
            }
        }
        return true;
    }
    public bool checkMission1()
    {
        for (int i = 0; i < 2; i++)
        {
            bool tmp = invenInfo.ContainsKey(answer2[i]);
            if (!tmp)
            {
                return false;
            }
        }
        return true;
    }
    public void plusInven(GameObject item)
    {
        GameObject tmp = Instantiate(slot);
        try
        {
            invenInfo.Add(item.transform.tag, tmp);
        }
        catch
        {
            return;
        }

        if (invenInfo.Count < 5)
        {
            tmp.transform.SetParent(inven.transform);
        }
        else
        {
            tmp.transform.SetParent(inven1.transform);
        }
        tmp.transform.GetChild(0).GetComponent<mission_btn>().tag = item.transform.tag;
        Image pic = tmp.transform.GetChild(0).GetComponent<Image>();
        pic.sprite = Resources.Load("T_Icon_"+item.transform.tag, typeof(Sprite)) as Sprite;
    }
    public void eraseInven()
    {
        Destroy(invenInfo[curItemTag]);
        invenInfo.Remove(curItemTag);
        exitItemPanel();
    }
    public void popUp(string tag)
    {
        canMove = false;
        panel2.SetActive(true);
        curItemTag = tag;
        itemMsg.text = itemInfo[tag];
        itemImg.sprite = Resources.Load(tag, typeof(Sprite)) as Sprite;
    }

    public void exitItemPanel(){
        canMove = true;
        panel2.SetActive(false);
    }

    public void ImageOn()
    {
        if(phase == 0)
        {
            if (Image0[idx])
            {
                player.SetActive(true);
                npc.SetActive(false);
            }
            else
            {
                player.SetActive(false);
                npc.SetActive(true);
            }
        }
        else if (phase == 1)
        {
            if (Image1[idx])
            {
                player.SetActive(true);
                npc.SetActive(false);
            }
            else
            {
                player.SetActive(false);
                npc.SetActive(true);
            }
        }
        else
        {
            if (Image2[idx])
            {
                player.SetActive(true);
                npc.SetActive(false);
            }
            else
            {
                player.SetActive(false);
                npc.SetActive(true);
            }
        }
    }
}



