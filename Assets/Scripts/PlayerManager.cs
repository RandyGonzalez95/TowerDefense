using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public int currentSunAmount = 100;
    public Text stats;

    void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }
	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        stats.text = string.Format("Sun: {0}", currentSunAmount);
	}

    public void AddSun()
    {
        currentSunAmount += 25;
    }

    public void Purchase(int amount)
    {
        currentSunAmount -= amount;
    }
}
