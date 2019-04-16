using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    private float timeSinceLastSpawned; 
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private GameObject[] columns;
    private float spawnxposition = 10f;
    private int currentColumn = 0; 

    public GameObject columnPrefab; 
    public int columnPoolSize = 5;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

	// Use this for initialization
	void Start () {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime; 

        if(GameController.instance.gameover == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnyYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnxposition, spawnyYPosition);
            currentColumn++; 
            if(currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
	}
}
