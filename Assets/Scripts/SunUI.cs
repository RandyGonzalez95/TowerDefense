using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunUI : MonoBehaviour
{
    PlayerManager player;
    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void OnMouseDown()
    {
        player = PlayerManager.instance;

        player.AddSun();
        Destroy(gameObject);
    }
}
