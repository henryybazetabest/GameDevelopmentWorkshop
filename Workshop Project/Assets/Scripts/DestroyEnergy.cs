using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnergy : MonoBehaviour
{
    public float destroyTime = 45.0f; // Time in seconds before destroying the GameObject

    private void Start()
    {
        // Call the DestroyObject method after the specified time
        StartCoroutine(DestroyObject());
    }

    private IEnumerator DestroyObject()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(destroyTime);

        // Destroy the GameObject
        Destroy(gameObject);
    }
}
