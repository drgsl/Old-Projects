using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] c;
    int i;
    public Player1 change; 


    //public GameObject camera; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            change.changecamera();
            i++;
        }
            if (i >= 11)
            {
                i = 0;
                c[11].gameObject.SendMessage("Deactivate");
            }

            c[i + 1].gameObject.SendMessage("Activate");
            c[i].gameObject.SendMessage("Deactivate");
            
        }
    }
