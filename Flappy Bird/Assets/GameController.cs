using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance; 
    public GameObject gameovertext;
    public bool gameover = false;

    public Text scoreText;
    //public Text maxScoreText; 

    public float scrollSpeed = -1.5f;

    private int score = 0;
    //private int maxscore = 0; 

	// Use this for initialization
	void Awake ()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
        if(gameover == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdScored()
    {
        if (gameover)
        {
            return; 
        }
        score++;
        //if (score > maxscore)
        //{
        //    maxscore = score;
        //    maxScoreText.text = "Max Score: " + maxscore.ToString();
        //}
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameovertext.SetActive(true);
        gameover = true; 
    }
}
