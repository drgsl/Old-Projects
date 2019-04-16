using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suicide : MonoBehaviour {

	// Use this for initialization

    public float time = 0.1f;


    // Update is called once per frame
    void Update () {

        Destroy(gameObject, time);


    }
}

