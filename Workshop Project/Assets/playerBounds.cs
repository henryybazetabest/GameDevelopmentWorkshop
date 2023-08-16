using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBounds : MonoBehaviour
{
    public Transform minXBound;
    public Transform maxXBound;
    public Transform minYBound;
    public Transform maxYBound;

    private void Update()
    {
        
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minXBound.position.x, maxXBound.position.x);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minYBound.position.y, maxYBound.position.y);
        transform.position = clampedPosition;
    }

}
