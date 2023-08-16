using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineHEalthYellow : MonoBehaviour
{

    [SerializeField] public int maxbullets = 50;
    [SerializeField] public int currentHP = 50;

    public MachineShootYellow machineShootYellow;
    private void FixedUpdate()
    {
        Debug.Log("Yellow Machine Health is at" + currentHP);
        if (currentHP < 10)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        if (currentHP < 0)
        {
            Destroy(gameObject);
        }
    }

}
