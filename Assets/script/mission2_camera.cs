using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mission2_camera : MonoBehaviour
{
    public GameObject panel; 
    public Text msg; 
    public GameObject panel1; 
    public Text missionMsg; 
    
    public bool canMove;
    public int idx = 0;
    private RaycastHit hit; //마우스에 클릭된 객체
    private string[] script = { "안녕!", "약을 만들 때 필요한 물품을 갖다줄래?", "재료는 다음과 이거야 1. 보라색 물약을 만들기 위한 물약 조합 2. 스포이드 3. 보안경 4. 비커", "재료가 다 있으면 나한테 말해줘 그럼 다음 스테이지를 가게 해줄게!", "아직 재료가 다 없는 거 같아 실험실을 더 찾아줄래?", "재료를 다 찾아줬구나!! 이제 다음 스테이지로 가게 해줄게!" };

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        clickCheck();
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
                    Debug.Log("npc");
                    if (!panel.activeSelf)
                    {
                        canMove = false;
                        panel.SetActive(true);
                        msg.text = script[idx++];
                    }
                }
                if (hit.collider.gameObject.CompareTag("clue"))
                {
                    Debug.Log("clue");
                }
            }
        }
    }
    public void nextMsg()
    {
        if (idx < 4)
        {
            msg.text = script[idx];
            idx = idx + 1;
        }
        else if (idx == 4)
        {
            panel.SetActive(false);
            panel1.SetActive(true);
            missionMsg.text = "보라색 시약, 비커, 보안경,스포이드 찾기";
            canMove = true;
        }
        else
        {
            if (checkMission())
            {
                msg.text = script[4];
                //씬 로드
            }
            else
            {
                msg.text = script[3];
            }
            panel.SetActive(false);
            canMove = true;
        }
    }
    public bool checkMission(){
        return true;
    }
}