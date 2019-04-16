using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject[] weapons;
    GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i].SetActive(false);
                
                if(this.tag == weapons[i].tag)
                {
                    weapons[i].SetActive(true);
                    //gameObject.SetActive(false);

                    //if (weapons[i].activeSelf == true)
                    //{

                    //    Instantiate(this, transform.position, transform.rotation);
                    //}
                    //Destroy(this.gameObject);
                }
            }

        }
    }

}
