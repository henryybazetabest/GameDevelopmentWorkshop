using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChromaHEalth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Objective; 
    public GameObject GameOverPanel;
    public int ObjectiveHealth; 





    // Update is called once per frame
    

        
    void Update()
    {
        ObjectiveHealth = Objective.GetComponent<Objective>().currentHp; 


        if (ObjectiveHealth <= 0)
        {
            Invoke("Reload", 2f);
            


           
        }
    }
    private void Reload()
    {

        Debug.Log("Game Over");
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;

    }
}
