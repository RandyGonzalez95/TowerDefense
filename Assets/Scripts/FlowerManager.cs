using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject sun;

    private float countdown = 10f;

	
	// Update is called once per frame
	void Update ()
    {
        if (countdown <= 0f)
        {
            SpawnSun();
            countdown = 10f;
        }

        countdown -= Time.deltaTime;
    }

    void SpawnSun()
    {   
        Instantiate(sun, spawnPoint.position, Quaternion.identity);
    }
}
