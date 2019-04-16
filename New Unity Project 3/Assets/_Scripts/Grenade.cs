using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

    public float delay = 1.5f;
    public float radius = 5f;
    public float force = 700f;

    public GameObject explosionEffect; 

    float countdown;
    bool hasExploaded = false; 



	// Use this for initialization
	void Start () {
        countdown = delay; 
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploaded)
        {
            Explode();
            hasExploaded = true; 
        }
    }

    void Explode ()
    {
        //show effect
        Instantiate(explosionEffect, transform.position, transform.rotation);

        //Get nearby objects
        Collider[] CollidersToDestroy = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in CollidersToDestroy)
        {
            // Damage
            Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.Destroy();
            }
        }

        Collider[] CollidersToMove = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in CollidersToMove)
        {
            // Add Force
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }


        // Remove grenade
        Destroy(gameObject);
    }

}
