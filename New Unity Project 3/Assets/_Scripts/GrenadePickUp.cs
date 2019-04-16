using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadePickUp : MonoBehaviour {

    float Ammo = GrenadeTrower.Ammo;
    float MaxAmmo = GrenadeTrower.MaxAmmo;
    GameObject player;
    //GrenadeTrower Ammo;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && GrenadeTrower.Ammo < GrenadeTrower.MaxAmmo)
        {
            GrenadeTrower.Ammo++; 
            ScoreManager.score = (int) GrenadeTrower.Ammo;
            Debug.Log(GrenadeTrower.Ammo);
            Destroy(gameObject);
        }
    }
}