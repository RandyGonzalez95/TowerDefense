using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public int currentSunAmount = 100;
    public int lives = 3;
    public Text stats;
    public GameObject endGamePanel;
    public Text ending;

    private float timeRemaining = 5;

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
        stats.text = string.Format("Sun: {0}      Lives: {1}", currentSunAmount, lives);

        if(lives <= 0)
        {
            // end game
            //Time.timeScale = 0;
            endGamePanel.SetActive(true);
            stats.text = string.Format("Sun: {0}      Lives: {1}", 0, 0);
            ending.text = string.Format("Game Ending in: {0:00}", timeRemaining);
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0.2)
                SceneManager.LoadScene("EndGame");

            Destroy(gameObject, timeRemaining);
            //SceneManager.LoadScene("EndGame");
            //Application.LoadLevel("EndGame");
        }


    }

    public void AddSun()
    {
        currentSunAmount += 25;
    }

    public void Purchase(int amount)
    {
        currentSunAmount -= amount;
    }

    public void LoseLife()
    {
        lives--;
    }
}
