using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachineSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] Allobject;
    public GameObject nearestOBJ = null;
    public float nearestDistance = 50;
    public float minimumDistanceThreshold = 8f;
    
    
    public GameObject RedMachineRB;
    public GameObject YellowMachineRB;
    public GameObject BlueMachineRB;
    public GameObject ground;
    public PlayerEnergyPickup PlayerEnergyPickup;
    public GameObject player; 
    public WorldColour worldColour;
     
    private void Start()
    {
        

        

        PlayerEnergyPickup = player.GetComponent<PlayerEnergyPickup>();
        
    }

    void Update()
    {
        // Find the nearest machine and update nearestOBJ and nearestDistance
        Allobject = GameObject.FindGameObjectsWithTag("Machine");
        nearestDistance = 50; // Reset nearestDistance to a high value

        for (int i = 0; i < Allobject.Length; i++)
        {
            float distance = Vector3.Distance(this.transform.position, Allobject[i].transform.position);
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestOBJ = Allobject[i];
            }
        }

        // Check if the player is close to the nearest machine and prevent instantiation if true


        if (Input.GetKeyDown(KeyCode.S))
        {

            if (nearestDistance < minimumDistanceThreshold)
            {
                Debug.Log("Too close to an existing machine. Cannot place a new one.");
                return; // Prevent instantiation of the new machine
            }

            // Instantiate the new machine if the player is not too close to any existing machine
            if (Input.GetKeyDown(KeyCode.S) &&  ground.GetComponent<SpriteRenderer>().sprite == worldColour.RedSprite && PlayerEnergyPickup.RedEnergyCount > 9)
            {
                Instantiate(RedMachineRB, transform.position, Quaternion.identity);
                PlayerEnergyPickup.RedEnergyCount -= 10;
            }
            else if (Input.GetKeyDown(KeyCode.S) && ground.GetComponent<SpriteRenderer>().sprite == worldColour.BlueSprite && PlayerEnergyPickup.BlueEnergyCount > 9)
            {
                Instantiate(BlueMachineRB, transform.position, Quaternion.identity);
                PlayerEnergyPickup.BlueEnergyCount -= 10;
            }
            else if (Input.GetKeyDown(KeyCode.S) &&  ground.GetComponent<SpriteRenderer>().sprite == worldColour.YellowSprite && PlayerEnergyPickup.YellowEnergyCount > 9)
            {
                Instantiate(YellowMachineRB, transform.position, Quaternion.identity);
                PlayerEnergyPickup.YellowEnergyCount -= 10;
            }
            else
            {
                Debug.Log("Cannont plant machine. Check your energy kevel and nearby machines"); 
            }
        }

    }
}
