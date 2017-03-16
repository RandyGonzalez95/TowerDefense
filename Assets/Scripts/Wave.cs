using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{

    public GameObject enemy, enemy1, enemy2;
    public int count;
    public float rate;
    public int EnemiesAlive;

    public GameObject actual;

    void Start()
    {
        actual = RandomizeEnemy();
        EnemiesAlive = count;

        if(actual == null)
        {
            actual = enemy;
        }
    }

    GameObject RandomizeEnemy()
    {
        float random = Random.Range(0f, 100f);
        GameObject temp;

        if((random % 10) == 0)
        {
            temp = enemy1;
        }
        if(random == 1)
        {
            temp = enemy2;
        }
        else
        {
            temp = enemy;
        }
                
        return temp;
    }
}
