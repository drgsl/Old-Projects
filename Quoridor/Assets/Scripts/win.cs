using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class win : MonoBehaviour
{

    public GameObject wintext1;
    public GameObject wintext2;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player 1")
        {
            wintext1.SetActive(true);
        }
        if (other.gameObject.tag == "Player 2")
        {
            wintext2.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void exit()
    {
        Debug.Log("quit"); 
        Application.Quit(); 
    }
}
