using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour {

    public int poolSize;

    public GameObject asdobject;

	void Start ()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ob1 = Instantiate(asdobject);
            sdak.SetActive(false);
            GameObject ob2 = Instantiate(asdobject);
            sdak.SetActive(false);
            GameObject ob3 = Instantiate(asdobject);
            ob1.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
