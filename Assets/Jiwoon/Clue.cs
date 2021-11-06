using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public GameObject player;

    public void disappear()
    {
        gameObject.SetActive(false);
        player.GetComponent<Mission3_CharacterControl>().canMove = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
