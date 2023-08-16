using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBoundsScript : MonoBehaviour
{
    public Transform target; // The target object the camera should follow
    public Vector2 minPosition; // The minimum position the camera can reach
    public Vector2 maxPosition; // The maximum position the camera can reach
    public float smoothTime = 0.3f; // The smooth time for camera movement

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null)
            return;

        // Calculate the desired camera position based on the target position
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

        // Clamp the camera position to stay within the specified min and max positions
        targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

        // Smoothly move the camera towards the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}