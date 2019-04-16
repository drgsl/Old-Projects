using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public GameObject boss;
    public GameObject plane;
    public GameObject enemymanager;
    public GameObject winmenu;
    public Slider healthSlider; 


    // Update is called once per frame
    void Update () {


       // healthSlider.value = Target.health; 

        if (Target.isDead == true)
        {

            //boss.SetActive(false);
            //plane.SetActive(true);
            moving.bossdead = true;
            enemymanager.SetActive(false);
        }
    }

	}
