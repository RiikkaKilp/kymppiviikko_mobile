using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    ObjectPooler        objectPooler;
        
    GameObject[]        allTiles;

    public GameObject   leftTile, 
                        rightTile, 
                        straightTile;
    GameObject          currentTile,
                        newTile;

    Vector3             currentPosition,
                        destroyBox;

    void Start ()
    {
        allTiles = new GameObject[] { leftTile, rightTile, straightTile };

        objectPooler = ObjectPooler.Instance;

        currentTile = objectPooler.SpawnFromPool("StraightPiece", transform.position, Quaternion.identity);
        newTile = objectPooler.SpawnFromPool("StraightPiece", newTile.transform.GetChild(0).position, Quaternion.identity);
       
	}
}
