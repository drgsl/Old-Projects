using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {


    public static PlayerManager instance;
    public GameObject player;


    void Awake()
    {
        instance = this; 
    }

}
