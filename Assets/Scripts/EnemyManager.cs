using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [Header("Health")]
    public Image healthBar;
    public float startHealth;

    private bool isDead = false;
    public float currentHealth;
    
    // Use this for initialization
    void Start()
    {
        currentHealth = startHealth;
     
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

}
