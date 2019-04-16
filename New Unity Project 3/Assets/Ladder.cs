using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    bool canClimb = false;
    float speed = 10f;

    void Update()
    {
        if (canClimb == true && Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        if (canClimb == true && Input.GetKeyDown(KeyCode.E))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter()
    {
        canClimb = true;
    }
    void OnTriggerExit()
    {
        canClimb = false;
    }
}