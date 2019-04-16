using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondIdea : MonoBehaviour {

    public GameObject[] X;
    public GameObject[] O;
    public GameObject[] Space;
    public GameObject[] pozitie; 

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Q) && (Space[0].activeSelf == true))
        {
            X[0].SetActive(true);
            Space[0].SetActive(false);
            this.pozitie[0].tag = "x"; 
        }
        if (Input.GetKeyDown(KeyCode.W) && (Space[1].activeSelf == true))
        {
            X[1].SetActive(true);
            Space[1].SetActive(false);
            this.pozitie[1].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.E) && (Space[2].activeSelf == true))
        {
            X[2].SetActive(true);
            Space[2].SetActive(false);
            this.pozitie[2].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.A) && (Space[3].activeSelf == true))
        {
            X[3].SetActive(true);
            Space[3].SetActive(false);
            this.pozitie[3].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.S) && (Space[4].activeSelf == true))
        {
            X[4].SetActive(true);
            Space[4].SetActive(false);
            this.pozitie[4].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.D) && (Space[5].activeSelf == true))
        {
            X[5].SetActive(true);
            Space[5].SetActive(false);
            this.pozitie[5].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.Z) && (Space[6].activeSelf == true))
        {
            X[6].SetActive(true);
            Space[6].SetActive(false);
            this.pozitie[6].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.X) && (Space[7].activeSelf == true))
        {
            X[7].SetActive(true);
            Space[7].SetActive(false);
            this.pozitie[7].tag = "x";
        }
        if (Input.GetKeyDown(KeyCode.C) && (Space[8].activeSelf == true))
        {
            X[8].SetActive(true);
            Space[8].SetActive(false);
            this.pozitie[8].tag = "x";
        }



        if (Input.GetKeyDown(KeyCode.Keypad7) && (Space[0].activeSelf == true))
        {
            O[0].SetActive(true);
            Space[0].SetActive(false);
            this.pozitie[0].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) && (Space[1].activeSelf == true))
        {
            O[1].SetActive(true);
            Space[1].SetActive(false);
            this.pozitie[1].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) && (Space[2].activeSelf == true))
        {
            O[2].SetActive(true);
            Space[2].SetActive(false);
            this.pozitie[2].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) && (Space[3].activeSelf == true))
        {
            O[3].SetActive(true);
            Space[3].SetActive(false);
            this.pozitie[3].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) && (Space[4].activeSelf == true))
        {
            O[4].SetActive(true);
            Space[4].SetActive(false);
            this.pozitie[4].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) && (Space[5].activeSelf == true))
        {
            O[5].SetActive(true);
            Space[5].SetActive(false);
            this.pozitie[5].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) && (Space[6].activeSelf == true))
        {
            O[6].SetActive(true);
            Space[6].SetActive(false);
            this.pozitie[6].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) && (Space[7].activeSelf == true))
        {
            O[7].SetActive(true);
            Space[7].SetActive(false);
            this.pozitie[7].tag = "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) && (Space[8].activeSelf == true))
        {
            O[8].SetActive(true);
            Space[8].SetActive(false);
            this.pozitie[8].tag = "0";
        }

    }
}
