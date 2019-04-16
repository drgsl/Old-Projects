using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLift : MonoBehaviour {

    GameObject player;
    public GameObject lift; 

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // ... the player is in range.
            lift.SetActive(true);
        }
    }
}
