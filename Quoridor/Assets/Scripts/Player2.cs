using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public static bool moving=false;
    public bool inputEnabled = false;
    public GameObject Halo;
    public GameObject c1;
    public GameObject c2;
    public GameObject pf, pb, pl, pr;
    public static bool dc = true, p1 = false, lc = false, p2 = false;



    void Update()
    {

        if (inputEnabled == true)
        {
            Halo.SetActive(true);
            if (dc == true)
            {
                DoubleCamera();
            }
            if (lc == true)
            {
                LateralCamera();
            }
            if (p1 == true)
            {
                P1Camera();
            }
            if (p2 == true)
            {
                P2Camera();
            }
        }
    }

    public void changecamera()
    {
        c1.SetActive(true);
        c2.SetActive(false);
    }

    void DoubleCamera()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && pb.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, 1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && pf.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, -1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && pr.activeSelf == true)
        {
            transform.Translate(-1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && pl.activeSelf == true)
        {
            transform.Translate(1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            transform.Rotate(Vector3.down, 90);
            changecamera();

        }
    }

    void LateralCamera()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && pl.activeSelf == true)
        {
            transform.Translate(1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && pr.activeSelf == true)
        {
            transform.Translate(-1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && pb.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, 1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && pf.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, -1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            transform.Rotate(Vector3.down, 90);
            changecamera();
        }
    }

    void P1Camera()
    {
            if (Input.GetKeyDown(KeyCode.DownArrow) && pf.activeSelf == true)
            {
                transform.Translate(0.0f, 0.0f, -1.0f, Space.World);
                changecamera();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && pb.activeSelf == true)
            {
                transform.Translate(0.0f, 0.0f, 1.0f, Space.World);
                changecamera();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && pl.activeSelf == true)
            {
                transform.Translate(1.0f, 0.0f, 0.0f, Space.World);
                changecamera();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && pr.activeSelf == true)
            {
                transform.Translate(-1.0f, 0.0f, 0.0f, Space.World);
                changecamera();
            }
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                transform.Rotate(Vector3.down, 90);
                changecamera();
            }
    }

    void P2Camera()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && pb.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, 1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && pf.activeSelf == true)
        {
            transform.Translate(0.0f, 0.0f, -1.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && pr.activeSelf == true)
        {
            transform.Translate(-1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && pl.activeSelf == true)
        {
            transform.Translate(1.0f, 0.0f, 0.0f, Space.World);
            changecamera();
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            transform.Rotate(Vector3.down, 90);
            changecamera();

        }
    }
    void Activate()
    {
        inputEnabled = true;
    }

    void Deactivate()
    {
        inputEnabled = false;
        Halo.SetActive(false);
    }


}
