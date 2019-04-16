using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Collections;

public class DisappearingPlatform : MonoBehaviour
{

    public GameObject playerLocater;


    // Use this for initialization
    void Start()

    {

        playerLocater = GameObject.Find("test");


    }


    void OnCollisionEnter(Collision disappearingPlatform)

    {
        if (disappearingPlatform.gameObject == playerLocater)

        {
            Destroy(gameObject);

        }

    }


}