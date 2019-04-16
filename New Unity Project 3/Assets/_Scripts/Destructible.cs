using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject destroyedVersion;

    public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.

    // Use this for initialization
    public void Destroy ()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}
