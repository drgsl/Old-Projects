using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliders : MonoBehaviour
{

    //public GameObject pl;
    //public GameObject pr;
    //public GameObject pf;
    //public GameObject pb;
    //public GameObject cl, cr, cf, cb;

    public GameObject p; 

    void OnTriggerEnter(Collider c)
    {
        // If the entering collider is the player...
        if (c.gameObject.tag == "wall")
        {
            p.SetActive(false);
        }
        
    }
    private void OnTriggerExit(Collider c)
    {
        p.SetActive(true);
    }
}
