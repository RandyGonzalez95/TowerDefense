using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooter : MonoBehaviour
{
    // Zombie vars
    private string zombieTag = "zombie";

    [Header("Attributes")]
    // Shooting Mechanics
    public float fireRate;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]

    private float shortestDistance;

    // Target Aim
    private Transform target;
    public float range = 5f;

    public Transform turnToRotate;

    // Bullet 
    [Header("Bullet Information")]
    public GameObject bulletPrefab;
    public Transform firePoint;


    // Use this for initialization
    void Start ()
    {
        // Call function 2 times per second
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}
	
    void UpdateTarget()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag(zombieTag);
        float distance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        // Loop through number of active enemies on the board
        foreach(GameObject enemy in zombies)
        {
            // Check distance between tower and our target
            float distanceToEnemy = Vector3.Distance(this.transform.position, enemy.transform.position); 

            // update our distance and target
            if(distanceToEnemy < distance)
            {
                distance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        // Check if we are within range and set our target zombie
        if(nearestEnemy != null && distance <= range)
        {
            target = nearestEnemy.transform;
        }
     }

	// Update is called once per frame
	void Update ()
    {
        // if there is no target do nothing
        if (target == null)
            return;

        // find the direction between our tower and target
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;

        turnToRotate.rotation = Quaternion.Euler(0f, 0f, -rotation.x);

        if(fireCountdown < 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
	}

    void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletMgr actualBullet = bullet.GetComponent<bulletMgr>();

        if(actualBullet != null)
        {
            actualBullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

    }
}
