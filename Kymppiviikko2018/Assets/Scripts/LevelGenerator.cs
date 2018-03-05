using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public List<GameObject>    allTiles = new List<GameObject>();
    GameObject[]        corners;

    public GameObject   leftTile,
                        rightTile,
                        straightTile;

    GameObject          currentTile,
                        newTile;

    public int          chunkSize;
    int                 rnd;

    Vector3             currentPosition;

    void Start ()
    {
        corners = new GameObject[] { leftTile, rightTile, straightTile };
        StartChunkSpawner();       
	}

    void StartChunkSpawner()
    {
        currentTile = Instantiate(straightTile, transform.position, transform.rotation);
        currentTile.transform.parent = gameObject.transform;
        allTiles.Add(currentTile);
        newTile = Instantiate(straightTile, currentTile.transform.GetChild(0).position, transform.rotation);
        currentTile.transform.parent = gameObject.transform;
        allTiles.Add(newTile);

    }
    public void NewChunkOnTrigger()
    {
        Debug.Log("New chunk called");

        for(int i = 0; i < chunkSize - 1; i++)
        {
            GameObject newTile = Instantiate(straightTile, currentTile.transform.GetChild(0).position, transform.rotation);
            newTile.transform.parent = gameObject.transform;
            currentTile = newTile;
            allTiles.Add(newTile);
        }

        rnd = Random.Range(0, 2);
        newTile = Instantiate(corners[rnd], currentTile.transform.GetChild(0).position, transform.rotation);
        currentTile = newTile;
        allTiles.Add(newTile);
    }
    public void DestroyChunk()
    {
        Debug.Log("Destroy called");
        for (int i = 0; i < chunkSize; i++)
        {
            GameObject toBeDestroyed = allTiles[0];
            Destroy(toBeDestroyed);
            allTiles.RemoveAt(0);
        }
    }
}
