using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    public GameObject[] c;
    int i;
    //public GameObject camera; 
    public Player2 change; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
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
