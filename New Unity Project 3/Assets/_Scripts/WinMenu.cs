using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WinMenu : MonoBehaviour {

    public GameObject WinMenuUI;
    public GameObject PauseMenu;
    public static bool LevelCompleted = false; 
    public float ScoreToWin = 10f; 


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Target.playerScore >= ScoreToWin)
        {
            Cursor.visible = true; 
            Time.timeScale = 0f;
            LevelCompleted = true;
            WinMenuUI.SetActive(true);
            PauseMenu.SetActive(false); 
        }
    }

   public void Continue()
    {
        Cursor.visible = true;
        Time.timeScale = 1f;
        WinMenuUI.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void LevelSelection()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Selection");
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        Application.Quit(); 
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1");
    }
}
