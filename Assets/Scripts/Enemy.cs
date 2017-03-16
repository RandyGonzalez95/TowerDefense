using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    PlayerManager player;

	// Use this for initialization
	void Start ()
    {

        target = Waypoints.points[0];
        player = PlayerManager.instance;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        bool flag = (Vector3.Distance(transform.position, target.position) <= 0.2f);

        if (flag)
        {
            GetNextWaypoint();
        }
	}

    void GetNextWaypoint()
    {
        // Zombie has reach the last waypoint
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            player.LoseLife();
            
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
