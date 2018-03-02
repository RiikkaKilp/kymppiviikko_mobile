﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

    [System.Serializable]
    public class Pool
    {
        public string          tag;
        public GameObject      prefab;
        public int             poolSize;
    }

    #region Singleton
    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public List<Pool>          pools;

    public Dictionary<string, Queue<GameObject>> poolDictionary;


    void Start ()
    {
		poolDictionary = new Dictionary < string, Queue < GameObject >>();

        foreach(Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.poolSize; i++)
            {
                GameObject gobj = Instantiate(pool.prefab);
                gobj.SetActive(false);
                objectPool.Enqueue(gobj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool (string tag, Vector3 position, Quaternion rotation)
    {
 //      if (!poolDictionary.ContainsKey(tag))
 //      {
 //          Debug.LogWarning("Pool with tag" + tag + " does not excist.");
 //          return null;
 //      }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}
