using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndMenu : MonoBehaviour
{

    public GameObject Pause; 

    void Start()
    {
        //Set Cursor to  be visible
        Cursor.visible = true;
        Pause.SetActive(false);

    }

    public void Replay()
    {
        Time.timeScale = 1f;
        Target.playerScore = 0;
        Application.LoadLevel(Application.loadedLevel);
    }


    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting game....");
    }
}