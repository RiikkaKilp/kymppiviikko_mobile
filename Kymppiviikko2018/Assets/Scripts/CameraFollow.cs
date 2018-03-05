using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform    target;
    Transform           localTarget;

    public float        smoothSpeed;

    public Vector3      offset;

    Vector3             velocity = Vector3.zero;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 toBe = transform.TransformPoint(desiredPosition);
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
