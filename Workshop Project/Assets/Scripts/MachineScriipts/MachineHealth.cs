using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineHealth : MonoBehaviour
{
    [SerializeField] public int maxHP = 10;
    [SerializeField] public int currentHP = 10;
    private bool isCooldown = false;
    private float cooldownDuration = 1.0f; // Cooldown duration in seconds

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isCooldown && other.gameObject.CompareTag("redEnemy"))
        {
            currentHP--;

            if (currentHP < 5)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
            }

            if (currentHP <= 0)
            {
                Destroy(gameObject);
            }

            StartCoroutine(StartCooldown());
        }
    }

    private IEnumerator StartCooldown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(cooldownDuration);
        isCooldown = false;
    }
}
