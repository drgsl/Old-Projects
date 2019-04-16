using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    Dropdown m_Dropdown;
   // public Text m_Text;
    public GameObject Cameras;
    public GameObject P1;
    public GameObject P2; 
    public GameObject Lateral;
    //public GameObject Player1, Player2; 

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(m_Dropdown);
        });

    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {

        if (change.value == 0)
            ShowDoubleCameras();
        else if (change.value == 1)
            ShowLateralCamera();
        else if (change.value == 2)
            ShowP1Camera();
        else
            ShowP2Camera(); 
        
    }


    //public bool DoubleCameras; 

    // public void ToggleCameras(int cameraindex)

    public void ShowDoubleCameras()
    {
        Cameras.SetActive(true);
        P1.SetActive(false);
        P2.SetActive(false);
        Lateral.SetActive(false);
        //Player1.Instance.SendMessage("dcf");
        Player1.dc = true;
        Player1.p1 = false;
        Player1.lc = false;
        Player1.p2 = false;

        Player2.dc = true;
        Player2.p1 = false;
        Player2.lc = false;
        Player2.p2 = false;
    }

    public void ShowLateralCamera()
    {
        Cameras.SetActive(false);
        P1.SetActive(false);
        P2.SetActive(false);
        Lateral.SetActive(true);
        //Player1.Instance.SendMessage("lcf");
        Player1.dc = false;
        Player1.p1 = false;
        Player1.lc = true;
        Player1.p2 = false;

        Player2.dc = false;
        Player2.p1 = false;
        Player2.lc = true;
        Player2.p2 = false;

    }

    public void ShowP1Camera()
    {
        Cameras.SetActive(false);
        P1.SetActive(true);
        P2.SetActive(false);
        Lateral.SetActive(false);
        //Player1.Instance.SendMessage("ucf");
        Player1.dc = false;
        Player1.p1 = true;
        Player1.lc = false;
        Player1.p2 = false;

        Player2.dc = false;
        Player2.p1 = true;
        Player2.lc = false;
        Player2.p2 = false;
    }

    public void ShowP2Camera()
    {
        Cameras.SetActive(false);
        P1.SetActive(false);
        P2.SetActive(true);
        Lateral.SetActive(false);
        //Player1.Instance.SendMessage("ucf");
        Player1.dc = false;
        Player1.p1 = false;
        Player1.lc = false;
        Player1.p2 = true;

        Player2.dc = false;
        Player2.p1 = false;
        Player2.lc = false;
        Player2.p2 = true;
    }
}