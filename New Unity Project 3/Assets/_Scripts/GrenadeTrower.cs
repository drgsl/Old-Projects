using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeTrower : MonoBehaviour {

    public float trowForce = 40f;
    public GameObject grenadePrefab;
    public float MaximumAmmo = 4f; 
    public static float MaxAmmo = 4;
    public static float Ammo;


    void Awake()
    {
        MaxAmmo = MaximumAmmo; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Ammo >= 1 && Ammo <= MaxAmmo)
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                TrowGrenade();
            }
        }

    }
    void TrowGrenade()
    {
        Ammo--;
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * trowForce, ForceMode.VelocityChange);
    }
}
