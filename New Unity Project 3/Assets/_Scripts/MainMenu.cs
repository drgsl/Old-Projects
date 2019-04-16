using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour {

    void Start()
    {
        //Set Cursor to be visible
        Cursor.visible = true;
        Time.timeScale = 1f;
    }


    public void PlayGame ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);                                 //SceneManager.LoadScene ("1")
    }

    public void QuitGame ()
    {
        Application.Quit(); 
    }

}
