using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CompletedLevel : MonoBehaviour {

    public GameObject bifa; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (WinMenu.LevelCompleted == true){
            bifa.SetActive(true); 
        }

	}
}
