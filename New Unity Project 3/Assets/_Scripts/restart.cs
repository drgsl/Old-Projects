using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
