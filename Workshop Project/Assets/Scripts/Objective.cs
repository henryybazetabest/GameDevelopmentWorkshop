using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    public int maxHp = 1000;
    public int currentHp = 1000;
    [SerializeField] StatusBar hpBar;
    public GameObject ObjectiveHealth;
    public Sprite normalhealthbar;
    public Sprite crackedhealthbar;
    Enemy enemy;

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        

        if (currentHp < 500 && currentHp> 0)
        {
            ObjectiveHealth.GetComponent<Image>().sprite = crackedhealthbar;

        }
        
        if (currentHp <= 0)
        {
            
        }
        hpBar.SetState(currentHp, maxHp);
    }
}
