using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{

    public GameObject[] a;
    public GameObject Player1, Player2, Draw;

    // Update is called once per frame
    void Update()
    {
            win(0, 1, 2);
            win(0, 3, 6);
            win(2, 5, 8);
            win(8, 7, 6);
            win(1, 4, 7);
            win(3, 4, 5);
            win(0, 4, 8);
            win(6, 4, 2);

            if (a[0].tag != "Empty" && a[1].tag != "Empty" && a[2].tag != "Empty" && a[3].tag != "Empty" && a[4].tag != "Empty" && a[5].tag != "Empty" && a[6].tag != "Empty" && a[7].tag != "Empty" && a[8].tag != "Empty" && Player1.activeSelf == false && Player2.activeSelf == false)
            {
                Draw.SetActive(true);
                Destroy(Player2);
                Destroy(Player1);
            }
        }

    void win(int b, int c, int d)
    {

        if (a[b].tag == a[c].tag && a[c].tag == a[d].tag && (a[d].tag == "x" || a[d].tag == "0"))
        {
            if (Player1 != null && Player2 != null)
            {
                if (a[d].tag == "x")
                {
                    Player1.SetActive(true);
                    Destroy(Player2);
                    Destroy(Draw); 
                }
                else if (a[d].tag == "0")
                {
                    Player2.SetActive(true);
                    Destroy(Player1);
                    Destroy(Draw);
                }
            }
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
