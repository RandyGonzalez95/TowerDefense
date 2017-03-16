using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SunManager : MonoBehaviour
{
    public int sunAmount = 100;
    public GameObject sun;

    private float x, y; // used to randomize location of sun
    public float spawnRate = 2f;
    private Vector3 spawnPoint;

    private float countdown = 10f;


	// Use this for initialization
	void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(countdown <= 0f)
        {
            SpawnSun();
            countdown = 10f;
        }         

        countdown -= Time.deltaTime;     
    }

    void SpawnSun()
    {
        x = Random.Range(-9.5f, 9.5f);
        y = Random.Range(-3f, 3f);

        spawnPoint = new Vector3(x, y, 0f);
        Instantiate(sun, spawnPoint, Quaternion.identity);
    }


}
