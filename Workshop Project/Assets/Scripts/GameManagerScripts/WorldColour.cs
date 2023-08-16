using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldColour : MonoBehaviour
{
    
    public GameObject ground;
    public GameObject RedMachine;
    public GameObject BlueMachine;
    public GameObject YellowMachine;
    public Sprite RedSprite;
    public Sprite BlueSprite;
    public Sprite YellowSprite;
    public bool isBlue;
    public bool isRed; 
    public bool isYellow;
   



    void Update()
    {
        ground = GameObject.FindGameObjectWithTag("ground");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            


            // Get the SpriteRenderer component from the RedMachine GameObject
            SpriteRenderer redSpriteRenderer = ground.GetComponent<SpriteRenderer>();
            redSpriteRenderer.sprite = RedSprite;
            isRed = true;
            isBlue = false;
            isYellow = false;
           
       



            // Set the color of the SpriteRenderer to red

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Create a new Color object for "Blue"
            

            // Get the SpriteRenderer component from the BlueMachine GameObject
            SpriteRenderer blueSpriteRenderer = ground.GetComponent<SpriteRenderer>();
            blueSpriteRenderer.sprite = BlueSprite;
            isRed = false;
            isBlue = true;
            isYellow = false;





            // Set the color of the SpriteRenderer to blue

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Create a new Color object for "Yellow"
           

            // Get the SpriteRenderer component from the YellowMachine GameObject
            SpriteRenderer yellowSpriteRenderer = ground.GetComponent<SpriteRenderer>();

            // Set the color of the SpriteRenderer to yellow
            yellowSpriteRenderer.sprite = YellowSprite;

            isRed = false;
            isBlue = false;
            isYellow = true;




        }
    }
}

