using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

    public SwipeHandler swipe;
    public Transform player;
    Vector3 desPos;

    // Update is called once per frame
    void Update ()
    {
        if (swipe.SwipeLeft)
        {
            //rot 90
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);
        }

        else if (swipe.SwipeRight)
        {
            //riot -90
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
        }

        else if (swipe.Tap)
        {
            Debug.Log("Tap!");
        }
    }
}
