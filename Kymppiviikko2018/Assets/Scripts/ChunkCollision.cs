using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkCollision : MonoBehaviour {

    public GameObject   SpawnArea,
                        LevelGenerator;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tile")
        {
         //   Debug.Log("Start of collision with a Tile");
            LevelGenerator.GetComponent<LevelGenerator>().NewChunkOnTrigger();
        }
//       else
//       {
//           Debug.Log("Start of unknown collision.");
//       }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tile")
        {
       //     Debug.Log("Collision ended with a Tile");
            LevelGenerator.GetComponent<LevelGenerator>().DestroyChunk();

        }
//       else
//       {
//           Debug.Log("End of unknown collision.");
//       }
    }
}
