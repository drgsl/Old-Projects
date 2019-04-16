using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFov : MonoBehaviour{

    Camera cam;
    GameObject player;


    void Start()
    {
        cam = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(player.transform.position);
        if (viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1 && viewPos.z > 0 )
        {
            if (Physics.Linecast(transform.position, player.transform.position))
                Debug.Log("blocked");
            else
            {
                // Your object is in the range of the camera, you can apply your behaviour
                Debug.DrawLine(transform.position, player.transform.position, Color.red, 10f, true);
                Debug.Log("yes");
            }

        }
        else
            Debug.Log("no");

    }
}