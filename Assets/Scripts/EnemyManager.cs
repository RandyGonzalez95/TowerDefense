using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

    public static EnemyManager instance;

    [Header("Health")]
    public Image healthBar;
    public float startHealth;

    private bool isDead = false;
    public float currentHealth;

    WaveSpawner waveManager;
    
    // Use this for initialization
    void Start()
    {
        currentHealth = startHealth;
        waveManager = WaveSpawner.instance;

        if (instance != null)
            return;

        instance = this;
     
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        healthBar.fillAmount = currentHealth / startHealth;

        if(healthBar.fillAmount < 0.7)
        {
            healthBar.color = Color.yellow;
        }
        if (healthBar.fillAmount < 0.4)
        {
            healthBar.color = Color.red;
        }
    }

    public void Kill()
    {
        waveManager.currentWave.EnemiesAlive--;
    }

}
