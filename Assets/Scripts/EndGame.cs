using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endButton;

    public void OnEnd()
    {
        Application.Quit();
    }

}
