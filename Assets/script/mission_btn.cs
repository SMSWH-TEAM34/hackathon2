using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class mission_btn : MonoBehaviour
{
    public string tag;
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        btn.onClick.AddListener(clickSlot);
    }
    public void clickSlot()
    {
        GameObject.FindWithTag("cam").GetComponent<mission2_camera>().popUp(tag);
    }

}
