using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkCollision : MonoBehaviour {

    public GameObject   tileSpawn,
                        tileDestroy;

    void OnTriggerEnter(Collider other)
    {
        if (other == tileSpawn)
        {
            Debug.Log("Collided with" + tileDestroy);
        }

        if (other == tileDestroy)
        {
            Debug.Log("Collided with" + tileDestroy);
        }
    }
}
