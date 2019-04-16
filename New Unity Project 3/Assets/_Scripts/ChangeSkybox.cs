using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSkybox : MonoBehaviour {

    public Material drunk;


    void OnTriggerEnter(Collider other)
    {
        RenderSettings.skybox = drunk;

    }
}
