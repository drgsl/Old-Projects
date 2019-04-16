using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checker : MonoBehaviour {


    public bool inputEnabled = false;



        void Activate()
        {
            inputEnabled = true;
        }

        void Deactivate()
        {
            inputEnabled = false;
        }
}
