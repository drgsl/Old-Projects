using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSImprove : MonoBehaviour {

    public Camera cam;
    GameObject prop;

    // Use this for initialization
    void Start () {
        prop = GameObject.FindGameObjectWithTag("prop");

    }

    // Update is called once per frame
    void Update () {

        Vector3 viewPos = cam.WorldToViewportPoint(prop.transform.position);
        if (viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1 && viewPos.z > 0)
        {
            // Your object is in the range of the camera, you can apply your behaviour
            Physics.Linecast(transform.position, prop.transform.position);
            Debug.Log("oui");
        }
        else
            Debug.Log("non");

    }

}
