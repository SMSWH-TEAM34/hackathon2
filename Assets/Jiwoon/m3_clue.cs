using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m3_clue : MonoBehaviour
{
    public GameObject player;

    public void disappear()
    {
        player.GetComponent<m3_move>().canMove = true;
        gameObject.SetActive(false);
    }
    
}
