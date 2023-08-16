using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineHealth : MonoBehaviour
{
    public int maxbullets = 50;
    public int currentHP = 50;

    public MachineShootRed machineShootRed;
    private void FixedUpdate()
    {

        Debug.Log("Red Machine Health is at" + currentHP); 
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
