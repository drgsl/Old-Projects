using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttack : MonoBehaviour {

    Animator anim;

    // Update is called once per frame
    void Update () {

        anim.SetTrigger("Attack");
    }
}
