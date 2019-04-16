using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScore : MonoBehaviour
{

    public  float playerScore = 0;
    // Use this for initialization
    void Update()
    {
        playerScore += Time.deltaTime;
        ScoreManager.timescore = ScoreManager.timescore + (int)playerScore;
    }

    void OnGUI()
    {

        GUI.Label(new Rect(30, 30, 10000, 500), "YOU SURVIVED FOR:  " + (int)(playerScore) + " seconds" );
    }
}
