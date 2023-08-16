using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineHealthBlue : MonoBehaviour
{

    [SerializeField] public int maxbullets = 50;
    [SerializeField] public int currentHP = 50;

    public MachineShootBlue machineShootBlue;
    private void FixedUpdate()
    {
        Debug.Log("Blue Machine Health is at" + currentHP);
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
