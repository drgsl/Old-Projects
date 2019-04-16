using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundcollider;
    private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
        groundcollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundcollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
