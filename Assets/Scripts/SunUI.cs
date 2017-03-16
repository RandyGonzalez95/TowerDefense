using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunUI : MonoBehaviour
{
    PlayerManager player;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

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
