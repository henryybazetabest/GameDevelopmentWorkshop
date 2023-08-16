using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesScrpt : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10.0f; // Adjust the force as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("blueEnemy") || other.CompareTag("redEnemy") || other.CompareTag("yellowEnemy"))
        {
            Rigidbody enemyRigidbody = other.GetComponent<Rigidbody>();
            if (enemyRigidbody != null)
            {
                Vector3 bounceDirection = (other.transform.position - transform.position).normalized;
                enemyRigidbody.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
            }
        }
    }
}
