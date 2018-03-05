using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public SwipeHandler swipe;
    public float        speed,
                        jumpForce,
                        jumpCooldown;
    float               collisionDistance;
    bool                isGrounded;
    Rigidbody           rb;
    Collider            col;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponentInChildren<Rigidbody>();
        col = GetComponentInChildren<CapsuleCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

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

            if (Grounded())
            {
                Debug.Log("Tap!");
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            }

            else
                Debug.Log("On air!");
        }
    }

    bool Grounded()
    {
        Debug.DrawRay(col.transform.position, Vector3.down, Color.green, 2);
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}
