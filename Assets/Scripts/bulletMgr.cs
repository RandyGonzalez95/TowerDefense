using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMgr : MonoBehaviour
{

    private Transform target;
    public GameObject effect;
    public float speed = 5f;

    public void Seek( Transform zombie )
    {
        // Pass in target zombie from our tower
        target = zombie;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        // Find our target direction to shoot the bullet
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // If we have hit our target
        if(dir.magnitude <= distanceThisFrame)
        {
            // We have reached our target
            HitTarget();
            return;
        }

        // Move our bullet at constant speed
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

    void HitTarget()
    {
        Destroy(gameObject); // destroy our bullet

        // Show Particle System
        GameObject effectInstance = (GameObject)Instantiate(effect, target.position, target.rotation);
        Destroy(effectInstance, 1.0f);        
    }


}
