using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstIdea : MonoBehaviour {

    static bool player1 = true;
    static bool player2 = false;
    static bool aux; 

    public GameObject pozitie, x, o; 


    private void OnMouseDown()
    {
        play();
        FirstIdea.aux = player2;
        FirstIdea.player2 = player1;
        FirstIdea.player1 = aux;
    }

    private void play()
    {
        if (FirstIdea.player1 == true)
        {
            //spatiu.SetActive(false);
            x.SetActive(true);
            o.SetActive(false);
            this.pozitie.tag = "x"; 
        }

        if (FirstIdea.player2 == true)
        {
            //spatiu.SetActive(false);
            x.SetActive(false);
            o.SetActive(true);
            this.pozitie.tag = "0";
        }

    }

}
