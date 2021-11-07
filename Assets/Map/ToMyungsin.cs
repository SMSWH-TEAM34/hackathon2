using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMyungsin : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void myungsinClikced()
    {
        SceneManager.LoadScene("Mission2");
    }

    public void baekClicked()
    {
        Debug.Log("baekjunyun");
        SceneManager.LoadScene("Mission3");
    }

    public void noClicked()
    {
        ui.SetActive(false);
    }
    

}
