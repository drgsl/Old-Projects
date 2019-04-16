using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {


    GameObject player;
    Animator anim; 

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // ... the player is in range.
            anim.SetBool("Open", true);
            //Destroy(gameObject); 
        }
    }
}
