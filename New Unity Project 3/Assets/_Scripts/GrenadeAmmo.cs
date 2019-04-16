using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GrenadeAmmo : MonoBehaviour
{
    public static int Ammo;

    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        Ammo = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Grenades: " + GrenadeTrower.Ammo;
    }
}