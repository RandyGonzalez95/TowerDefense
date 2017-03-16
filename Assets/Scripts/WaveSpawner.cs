using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static WaveSpawner instance; 

    [Header("Wave")]
    public Transform spawnPoint;

    public Wave[] waves;
    public Wave currentWave;
    private int waveIndex = 0;

    public float timeBetweenWaves = 60f;
    private float countdown = 2f;


    //public int EnemiesAlive;


	// Use this for initialization
	void Start ()
    {
        currentWave = waves[0];
        waveIndex = 0;

        if ( instance != null)
        {
            return;
        }

        instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
    

 

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        if(waveIndex == waves.Length)
        {
            // End Game
        }


        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

	}

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
       

        for(int i = 0; i< wave.count; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f / wave.rate);
        }

        waveIndex++;      

    }

    void SpawnEnemy()
    {
        Debug.Log("zombie spawned");
        Instantiate(waves[waveIndex].actual, spawnPoint.position, spawnPoint.rotation);
    }
}
